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
    public partial class Launcher : Form
    {
        // Selected Params
        private int scale = 1;
        public Launcher()
        {
            InitializeComponent();
        }

        private void levels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            var scale = scaleSelector.SelectedIndex + 1;
            var levelName = levelSelector.SelectedItem.ToString();
            var f = new Game(levelName, scale);
            f.Show();
            this.Hide();
        }

        private void resolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }
    }
}
