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
    public partial class MainMenu : Form
    {
        public int dif,mod;

        public MainMenu(int di,int mo)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameMode GM = new GameMode(dif,mod);
            Difficulty D = new Difficulty(dif,mod);

            if (mod == 1)
            {
                var f = new StartOperator(dif,mod);
                this.Hide();
                f.Show();
            }
            else if (mod==2)
            {
                var f = new StartVariable(dif, mod);
                this.Hide();
                f.Show();
            }
            else
            {
                var f = new StartResult(dif, mod);
                this.Hide();
                f.Show();
            }
        }

        private void GameMode_Click(object sender, EventArgs e)
        {
            var f = new GameMode(dif, mod);
            this.Hide();
            f.Show();
        }

        private void Difficulty_Click(object sender, EventArgs e)
        {
            var f = new Difficulty(dif, mod);
            this.Hide();
            f.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            var f = new About(dif, mod);
            this.Hide();
            f.Show();
        }
    }
}
