using System.Collections.Generic;
using System.Drawing;

namespace Wind.Forms
{
    public class ObjectToImage
    {
        private Dictionary<string, Bitmap> bitmaps = new Dictionary<string, Bitmap>
        {
            {"Terrain",GameObjects.Terrain},
        };
    }
}