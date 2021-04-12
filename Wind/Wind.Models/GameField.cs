namespace Wind.Models
{
    public class GameField
    {
        public readonly double Gravitation;
        public readonly int Width;
        public readonly int Height;

        public GameField(int width, int height, double gravitation)
        {
            Width = width;
            Height = height;
            Gravitation = gravitation;
        }
    }
}