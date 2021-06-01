using System.Collections.Generic;
using System.Drawing;

namespace Wind.Forms
{
    public class ObjectToImage
    {
        public readonly Dictionary<string, Bitmap> Bitmaps = new Dictionary<string, Bitmap>
        {
            {"Terrain",GameObjects.Terrain},
            {"FanU",GameObjects.FanFirstSpeed},
            {"FanUo",GameObjects.FanSecondSpeed},
            {"Sphere", GameObjects.FlyingObject},
            {"End",GameObjects.End}
        };
    }
}