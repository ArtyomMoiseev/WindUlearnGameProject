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
        private readonly IGameMapObject[,] level;
        private readonly int scale;
        private readonly AirFlowNode[,] airMap;
        private readonly int width;
        private readonly int height;
        public Game(string levelName, int scale, int width)
        {
            var reader = new LevelReader();
            level = reader.ReadLevel(levelName);
            this.scale = scale;
            var flow = new AirFlow();
            airMap = flow.CreateAirFlowMap(level);
            width = FormConst.ObjectSize * scale * level.GetLength(1);
            height = FormConst.ObjectSize * scale * level.GetLength(0);
            InitializeComponent();
            InitLayout();
            Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(width,height);
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

        private void TimerTick(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var toImage = new ObjectToImage();
            var start = 0;
            var size = FormConst.ObjectSize * scale;
            for (var i = 0; i < level.GetLength(1); i++)
            for (var j = 0; j < level.GetLength(0); j++)
            {
                if (level[j,i] == null)
                    continue;
                g.DrawImage(toImage.Bitmaps[level[j,i].ObjectImage], start + size * i, start + size * j, size, size);
            }

        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            var xPoint = e.X / (FormConst.ObjectSize * scale);
            var yPoint = e.Y / (FormConst.ObjectSize * scale);
            Console.WriteLine(xPoint);
            Console.WriteLine(yPoint);

        }
    }
}
