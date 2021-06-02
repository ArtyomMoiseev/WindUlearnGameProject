using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private IContainer components;
        private Timer timer1;
        private Point sphere;
        private bool levelIsDraw = false;
        public Game(string levelName, int scale)
        {
            var reader = new LevelReader();
            level = reader.ReadLevel(levelName);
            var hardCords = reader.FindSphere(levelName);
            sphere = new Point(FormConst.ObjectSize * scale * sphere.Y, FormConst.ObjectSize * scale * sphere.X);
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
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
            g.SmoothingMode = SmoothingMode.HighSpeed;
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

            levelIsDraw = true;

            g.DrawImage(GameObjects.FlyingObject,sphere.Y,sphere.X, size,size);

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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sphere.X++;
            sphere.Y++;
            this.Refresh();
        }
    }
}
