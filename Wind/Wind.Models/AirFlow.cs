using System;

namespace Wind.Models
{
    public class AirFlow
    {
        public double Flow;

        public AirFlow(double flow, Direction direction)
        {
            Flow = flow;
            Direction = direction;
        }

        public Direction Direction { get; }


        public AirFlow[,] CreateAirFlowMap(GameField field)
        {
            var flowMap = new AirFlow[field.Map.GetLength(0), field.Map.GetLength(1)];
            for (var i = 0; i < field.Map.GetLength(0); i++)
            for (var j = 0; j < field.Map.GetLength(1); j++)
            {
                var x = i;
                var y = j;
                var count = 0;
                if (field.Map[i, j].GetType() != typeof(FanMapObject)) continue;
                if (field.Map[i, j].direction == Direction.Down)
                    while (y <= field.Map.GetLength(1) || !field.Map[x, j].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlow(10 - count * GameConst.Attenuation, Direction.Down);
                        y++;
                        count++;
                    }

                else if (field.Map[i, j].direction == Direction.Up)
                    while (y >= 0 || !field.Map[x, j].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlow(10 - count * GameConst.Attenuation, Direction.Up);
                        y--;
                        count++;
                    }

                else if (field.Map[i, j].direction == Direction.Right)
                    while (x <= field.Map.GetLength(0) || !field.Map[i, y].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlow(10 - count * GameConst.Attenuation, Direction.Right);
                        x++;
                        count++;
                    }

                else if (field.Map[i, j].direction == Direction.Left)
                    while (x >= 0 || !field.Map[i, y].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlow(10 - count * GameConst.Attenuation, Direction.Left);
                        x--;
                        count++;
                    }
                else 
                    throw new Exception("Direction is not exist");
            }

            return flowMap;
        }
    }
}