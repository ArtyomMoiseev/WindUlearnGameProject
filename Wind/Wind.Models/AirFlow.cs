using System;
using System.Collections;

namespace Wind.Models
{
    public class AirFlow
    {
        public double Flow;
        public Direction Direction;

        public AirFlow(double flow, Direction direction)
        {
            Flow = flow;
            Direction = direction;
        }


        public AirFlow[] CreateAirFlowMap(GameField field)
        {
            var flowMap = new AirFlow[field.Map.GetLength(0),field.Map.GetLength(1)];
            for (var i = 0; i< field.Map.GetLength(0);i++)
            for (var j = 0; j < field.Map.GetLength(1); j++)
            {
                var x = i;
                var y = j;
                var count = 0;
                if (field.Map[i, j].GetType() != typeof(FanMapObject)) continue;
                if (field.Map[i, j].direction == Direction.Down)
                {
                    while (x < field.Map.GetLength(0) || !field.Map[x,j + 1].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlow(10 - count * GameConst.Attenuation, Direction.Down);
                        y++;
                        count++;
                    }
                }

            }
        }
    }
}