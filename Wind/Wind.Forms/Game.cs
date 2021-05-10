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
            var level = DefaultGameObjects.testMap;

            g.DrawImage(GameObjects.FanFirstSpeed,100,100,120,120);
            g.DrawImage(GameObjects.Terrain, 220, 100, 120, 120);
            g.DrawImage(GameObjects.FlyingObject, 340, 100, 120, 120); 
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            if (e.X <= 220 && e.X >= 100)
                throw new NotImplementedException();
        }
    }
}
