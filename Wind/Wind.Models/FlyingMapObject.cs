namespace Wind.Models
{
    public class FlyingMapObject : IGameMapObject
    {
        public readonly double Weight;
        public readonly double SurfaceArea;
        public readonly string ImageName;
        public readonly double TurnAngle;

        public FlyingMapObject(double weight, double surfaceArea, string imageName, double turnAngle)
        {
            Weight = weight;
            SurfaceArea = surfaceArea;
            ImageName = imageName;
            TurnAngle = turnAngle;
        }

        public bool IsStaticObject => false;
        public bool IsWall => true;
        public string ObjectImage => ImageName;
        public void Change()
        { }

        public double StreamForce { get; }

        public Direction direction { get; set; }
    }
}