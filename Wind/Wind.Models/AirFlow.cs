using System;

namespace Wind.Models
{
    public class AirFlowNode
    {
        public readonly double Flow;
        public readonly Direction Direction;

        public AirFlowNode(double flow, Direction direction)
        {
            this.Flow = flow;
            this.Direction = direction;
        }
    }
    public class AirFlow
    {
        public AirFlowNode[,] CreateAirFlowMap(IGameMapObject[,] map)
        {
            var flowMap = new AirFlowNode[map.GetLength(0), map.GetLength(1)];
            for (var i = 0; i < map.GetLength(0); i++)
            for (var j = 0; j < map.GetLength(1); j++)
            {
                var x = i;
                var y = j;
                var count = 0;
                if (map[i,j] == null || map[i, j].GetType() != typeof(FanMapObject)) continue;
                if (map[i, j].direction == Direction.Down)
                    while (y < map.GetLength(1) && !map[x, j].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlowNode(10 - count * GameConst.Attenuation, Direction.Down);
                        y++;
                        count++;
                    }

                if (map[i, j].direction == Direction.Up)
                    while (y > 0 && !map[x, j].IsStaticObject)
                    {
                        Console.WriteLine("a");
                        flowMap[i, y] = new AirFlowNode(10 - count * GameConst.Attenuation, Direction.Up);
                        y--;
                        count++;
                    }

                if (map[i, j].direction == Direction.Right)
                    while (x < map.GetLength(0) && !map[i, y].IsStaticObject)
                    {
                        flowMap[x, j] = new AirFlowNode(10 - count * GameConst.Attenuation, Direction.Right);
                        x++;
                        count++;
                    }

                if (map[i, j].direction == Direction.Left)
                    while (x >= 0 && !map[i, y].IsStaticObject)
                    {
                        flowMap[x, j] = new AirFlowNode(10 - count * GameConst.Attenuation, Direction.Left);
                        x--;
                        count++;
                    }
            }

            return flowMap;
        }
    }
}