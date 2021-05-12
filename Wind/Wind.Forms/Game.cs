using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wind.Models;

namespace Wind.Forms
{
    public sealed partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            InitLayout();
            Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClick);
            this.ResumeLayout(false);

        }

        private void Game_Load(object sender, EventArgs e)
        {
 
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var toImage = new ObjectToImage();
            var start = 0;
            var size = 80;
            var level = DefaultGameObjects.Field.Map;

            for (var i = 0; i < level.GetLength(0); i++)
            for (var j = 0; j < level.GetLength(1); j++)
            {
                if (level[i,j] == null)
                    continue;
                g.DrawImage(toImage.Bitmaps[level[i,j].ObjectImage], start + size * i, start + size * j, size, size);
            }
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            if (e.X <= 220 && e.X >= 100)
                throw new NotImplementedException();
        }
    }
}
