using System;
using System.IO;

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
                var count = 0;
                if (map[i,j] == null || map[i, j].GetType() != typeof(FanMapObject)) continue;
                if (map[i, j].direction == Direction.Down)
                {
                    var x = i + 1;
                    while (x < map.GetLength(0) && map[x, j] == null)
                    {
                        flowMap[x, j] = new AirFlowNode(map[i, j].StreamForce * GameConst.Attenuation, Direction.Down);
                        x++;
                        count++;
                    }
                }

                if (map[i, j].direction == Direction.Up)
                {
                    var x = i - 1;
                    while (x >= 0 && map[x, j] == null)
                    {
                        Console.WriteLine("w");
                        flowMap[x, j] = new AirFlowNode(map[i,j].StreamForce - count * GameConst.Attenuation, Direction.Up);
                        x--;
                        count++;
                    }
                }

                if (map[i, j].direction == Direction.Right)
                {
                    var y = j + 1;
                    while (y < map.GetLength(1) && !map[i, y].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlowNode(map[i, j].StreamForce - count * GameConst.Attenuation, Direction.Right);
                        y++;
                        count++;
                    }
                }

                if (map[i, j].direction == Direction.Left)
                {
                    var y = j - 1;
                    while (y >= 0 && !map[i, y].IsStaticObject)
                    {
                        flowMap[i, y] = new AirFlowNode(map[i, j].StreamForce - count * GameConst.Attenuation, Direction.Left);
                        y--;
                        count++;
                    }
                }
            }

            return flowMap;
        }
    }
}