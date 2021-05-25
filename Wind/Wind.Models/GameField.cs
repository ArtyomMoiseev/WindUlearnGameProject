using System.Drawing;

namespace Wind.Models
{
    public class GameField
    {
        public readonly double Gravitation;
        public readonly int Width;
        public readonly int Height;
        public readonly IGameMapObject[,] Map;
        public readonly Point point;

        public GameField(int width, int height, double gravitation, IGameMapObject[,] map, Point point)
        {
            Width = width;
            Height = height;
            Gravitation = gravitation;
            Map = map;
            this.point = point;
        }
    }
}