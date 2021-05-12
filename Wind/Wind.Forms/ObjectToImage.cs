using System.Collections.Generic;
using System.Drawing;

namespace Wind.Forms
{
    public class ObjectToImage
    {
        public readonly Dictionary<string, Bitmap> Bitmaps = new Dictionary<string, Bitmap>
        {
            {"Terrain",GameObjects.Terrain},
            {"FanFirstSpeed",GameObjects.FanFirstSpeed},
            {"FanSecondSpeed",GameObjects.FanSecondSpeed},
            {"End",GameObjects.End}
        };
    }
}