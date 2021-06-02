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
            {"FanR",RotateImage(GameObjects.FanFirstSpeed,90)},
            {"FanD",RotateImage(GameObjects.FanFirstSpeed,180)},
            {"FanL",RotateImage(GameObjects.FanFirstSpeed,270)},
            {"FanUo",GameObjects.FanSecondSpeed},
            {"FanRo",RotateImage(GameObjects.FanSecondSpeed,90)},
            {"FanDo",RotateImage(GameObjects.FanSecondSpeed,180)},
            {"FanLo",RotateImage(GameObjects.FanSecondSpeed,270)},
            {"Sphere", GameObjects.FlyingObject},
            {"End",GameObjects.End}
        };

        public static Bitmap RotateImage(Bitmap b, float angle)
        {
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }
    }
}