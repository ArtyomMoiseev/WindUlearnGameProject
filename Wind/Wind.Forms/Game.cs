using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind.Forms
{
    public partial class Game : Form
    {
        public Game()
        {
            //InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
