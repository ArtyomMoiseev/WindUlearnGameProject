using System.Runtime.CompilerServices;

namespace Wind.Models
{
    public class FanMapObject : IGameMapObject
    {
        public readonly double StreamForce;
        public Direction Direction;
        public readonly string ImageName;

        public FanMapObject(double streamForce, Direction direction, string imageName)
        {
            StreamForce = streamForce;
            Direction = direction;
            ImageName = imageName;
        }

        public bool IsStaticObject => false;
        public string ObjectImage => ImageName;

        public bool IsWall => true;
    }
}