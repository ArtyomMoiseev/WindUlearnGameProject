namespace Wind.Models
{
    public class DefaultGameObjects
    {

        public static IGameMapObject[,] testMap =
        {
            {Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain},
            {Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain, Terrain}
        };


        public static IGameMapObject Terrain = new StaticObject("Terrain.png",0,0);
        public static IGameMapObject Sphere = new FlyingMapObject(5,10, "FlyingObject.png", 0);
        public static IGameMapObject Fan = new FanMapObject(5, Direction.Up, "FanFirstSpeed.png");
        public static GameField Field = new GameField(16, 9, 9.81, testMap);

    }
}