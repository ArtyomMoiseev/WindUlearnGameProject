namespace Wind.Models
{
    public class GameField
    {
        public readonly double Gravitation;
        public readonly int Width;
        public readonly int Height;
        public readonly IGameMapObject[,] Map;

        public GameField(int width, int height, double gravitation, IGameMapObject[,] map)
        {
            Width = width;
            Height = height;
            Gravitation = gravitation;
            Map = map;
        }
    }
}