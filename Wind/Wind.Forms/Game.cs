using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
        private AirFlowNode[,] airMap;
        private readonly int width;
        private readonly int height;
        private Point sphere;
        public Game(string levelName, int scale)
        {
            var reader = new LevelReader();
            level = reader.ReadLevel(levelName);
            sphere = reader.FindSphere(levelName);
            this.scale = scale;
            UpdateAirMap();
            width = FormConst.ObjectSize * scale * level.GetLength(1);
            height = FormConst.ObjectSize * scale * level.GetLength(0);
            InitializeComponent();
            InitLayout();
            Invalidate();
        }

        private void UpdateAirMap()
        {
            var flow = new AirFlow();
            airMap = flow.CreateAirFlowMap(level);
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
            this.sta
            Console.WriteLine(1);
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
            var x = e.X / (FormConst.ObjectSize * scale);
            var y = e.Y / (FormConst.ObjectSize * scale);
            if (level[y,x] != null)
                level[y,x].Change();
            UpdateAirMap();
            this.Refresh();
        }
    }
}
