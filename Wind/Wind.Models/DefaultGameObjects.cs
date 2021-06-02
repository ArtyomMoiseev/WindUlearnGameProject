using System.Collections.Generic;
using System.Drawing;

namespace Wind.Models
{
    public class DefaultGameObjects
    {
        public static IGameMapObject Terrain = new StaticObject("Terrain", 0, 0);
        public static IGameMapObject End = new StaticObject("End", 0, 0);
        public static IGameMapObject Sphere = new FlyingMapObject(5, 10, "Sphere", 0);
        public static IGameMapObject FanD = new FanMapObject(Direction.Down,new List<FanMode>() 
        {
                new FanMode(0,"FanD"), 
                new FanMode(30,"FanDo")
        });
        public static IGameMapObject FanR = new FanMapObject(Direction.Right, new List<FanMode>()
        {
            new FanMode(0,"FanR"),
            new FanMode(30,"FanRo")
        });
        public static IGameMapObject FanL = new FanMapObject(Direction.Left, new List<FanMode>()
        {
            new FanMode(0,"FanL"),
            new FanMode(30,"FanLo")
        });
        public static IGameMapObject FanU = new FanMapObject(Direction.Up, new List<FanMode>()
        {
            new FanMode(0,"FanU"),
            new FanMode(30,"FanUo")
        });

    }
}