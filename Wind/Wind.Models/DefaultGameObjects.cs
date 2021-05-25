using System.Drawing;

namespace Wind.Models
{
    public static class DefaultGameObjects
    {
        public static IGameMapObject Terrain = new StaticObject("Terrain", 0, 0);
        public static IGameMapObject Sphere = new FlyingMapObject(5, 10, "FlyingObject", 0);
        public static IGameMapObject Fan = new FanMapObject(5, Direction.Up, "FanFirstSpeed");

        private static readonly IGameMapObject[,] TestMap =
        {
            {Terrain, Terrain, Terrain, Terrain, Terrain, Fan, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, null, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, null, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, null, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, null, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, Fan, Terrain, Terrain, Terrain}
        };

        public static GameField Field = new GameField(16, 9, 9.81, TestMap, new Point(1,1));

    }
}