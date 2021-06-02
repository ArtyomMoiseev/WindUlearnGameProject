using System;

namespace Wind.Models
{
    public class StaticObject : IGameMapObject
    {
        public readonly string ImageName;
        public readonly double TurnAngle;
        public readonly double Permeability;

        public StaticObject(string imageName, double turnAngle, double permeability)
        {
            ImageName = imageName;
            TurnAngle = turnAngle;
            Permeability = permeability;
        }

        public bool IsStaticObject => true;

        public bool IsWall => true;
        public string ObjectImage => ImageName;
        public void Change()
        {
        }

        public double StreamForce { get; }

        public Direction direction { get; set; }
    }
}
