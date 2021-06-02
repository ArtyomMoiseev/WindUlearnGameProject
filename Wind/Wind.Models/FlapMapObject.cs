using System;
using System.Collections.Generic;
using System.Text;

namespace Wind.Models
{
    class FlapMapObject : IGameMapObject
    {
        public readonly string ImageName;
        public readonly double FlapTurnAngle;
        public readonly double Permeability;

        public FlapMapObject(string imageName, double flapTurnAngle, double permeability)
        {
            ImageName = imageName;
            FlapTurnAngle = flapTurnAngle;
            Permeability = permeability;
        }

        public bool IsStaticObject => false;
        public bool IsWall => true;
        public string ObjectImage => ImageName;
        public void Change()
        {
        }

        public double StreamForce { get; }

        public Direction direction { get; set; }
    }
}
