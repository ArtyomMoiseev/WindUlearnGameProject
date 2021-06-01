using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Wind.Models
{
    public class FanMode
    {
        public readonly double StreamForce;
        public readonly string ImageName;

        public FanMode(double streamForce, string imageName)
        {
            StreamForce = streamForce;
            ImageName = imageName;
        }
    }
    public class FanMapObject : IGameMapObject
    {
        public double StreamForce;
        public Direction Direction;
        public string ImageName;
        private readonly List<FanMode> modeList;
        private int stateNum = 0;

        public FanMapObject(Direction direction, List<FanMode> modeList)
        {
            Direction = direction;
            this.modeList = modeList;
            StreamForce = modeList[0].StreamForce;
            ImageName = modeList[0].ImageName;
        }

        public (Direction, List<FanMode>) Copy()
        {
            return (direction, modeList);
        }

        public bool IsStaticObject => false;
        public string ObjectImage => ImageName;
        public void Change()
        {
            stateNum++;
            if (stateNum == modeList.Count)
                stateNum = 0;
            StreamForce = modeList[stateNum].StreamForce;
            ImageName = modeList[stateNum].ImageName;
        }

        public Direction direction { get; set; }

        public bool IsWall => true;
    }
}