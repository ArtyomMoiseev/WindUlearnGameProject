using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Wind.Models;

namespace Wind.Forms
{
    public class GameWindow : Form
    {
        private readonly Dictionary<string, Bitmap> bitmaps = new Dictionary<string, Bitmap>();
        //private readonly GameState gameState;
        private int tickCount;


        public DiggerWindow(DirectoryInfo imagesDirectory = null)
        {
            ClientSize = new Size(
                Game.ElementSize * GameField.Width,
                Game.ElementSize * GameField.Height + Game.ElementSize);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            if (imagesDirectory == null)
                imagesDirectory = new DirectoryInfo("Images");
            foreach (var e in imagesDirectory.GetFiles("*.png"))
                bitmaps[e.Name] = (Bitmap)Image.FromFile(e.FullName);
            var timer = new Timer();
            timer.Interval = 15;
            //timer.Tick += TimerTick;
            timer.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = "Wind";
            DoubleBuffered = true;
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(0, Game.ElementSize);
            e.Graphics.FillRectangle(
                Brushes.Black, 0, 0, Game.ElementSize * GameField.MapWidth,
                Game.ElementSize * GameField.MapHeight);
            //foreach (var a in gameState.Animations)
             //   e.Graphics.DrawImage(bitmaps[a.Creature.GetImageFileName()], a.Location);
            //e.Graphics.ResetTransform();
           // e.Graphics.DrawString(Game.Scores.ToString(), new Font("Arial", 16), Brushes.Green, 0, 0);
        }

        //private void TimerTick(object sender, EventArgs args)
        //{
        //    if (tickCount == 0) gameState.BeginAct();
        //    foreach (var e in gameState.Animations)
        //        e.Location = new Point(e.Location.X + 4 * e.Command.DeltaX, e.Location.Y + 4 * e.Command.DeltaY);
        //    if (tickCount == 7)
        //        gameState.EndAct();
        //    tickCount++;
        //    if (tickCount == 8) tickCount = 0;
        //    Invalidate();
        //}
    }
}