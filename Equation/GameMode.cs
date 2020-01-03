using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equation
{
    public partial class GameMode : Form
    {
        public int dif, mod;
        public GameMode(int di,int mo)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mod = 1;
            var f = new MainMenu(dif, mod);
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mod = 2;
            var f = new MainMenu(dif, mod);
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mod = 3;
            var f = new MainMenu(dif, mod);
            this.Hide();
            f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new MainMenu(dif, mod);
            this.Hide();
            f.Show();
        }
    }
}
