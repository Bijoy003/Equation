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
    public partial class Difficulty : Form
    {
        public int dif, mod;
        public Difficulty(int di,int mo)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
            if (dif == 1)
            {
                EasyButton.FlatAppearance.BorderSize = 1;
                EasyButton.BackColor = Color.Gray;
                EasyButton.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (dif == 2)
            {
                MediumButton.FlatAppearance.BorderSize = 1;
                MediumButton.BackColor = Color.Gray;
                MediumButton.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                HardButton.FlatAppearance.BorderSize = 1;
                HardButton.BackColor = Color.Gray;
                HardButton.FlatAppearance.BorderColor = Color.Gray;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dif = 1;
            var f = new MainMenu(dif,mod);
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dif = 2;
            var f = new MainMenu(dif,mod);
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dif = 3;
            var f = new MainMenu(dif,mod);
            this.Hide();
            f.Show();
        }

        private void EasyMouseEnter(object sender, EventArgs e)
        {
            EasyButton.FlatAppearance.BorderSize = 1;
            EasyButton.BackColor = Color.Green;
            EasyButton.FlatAppearance.BorderColor = Color.Green;
        }

        private void MediumMouseEnter(object sender, EventArgs e)
        {
            MediumButton.FlatAppearance.BorderSize = 1;
            MediumButton.BackColor = Color.Green;
            MediumButton.FlatAppearance.BorderColor = Color.Green;
        }

        private void HardMouseEnter(object sender, EventArgs e)
        {
            HardButton.FlatAppearance.BorderSize = 1;
            HardButton.BackColor = Color.Green;
            HardButton.FlatAppearance.BorderColor = Color.Green;
        }

        private void EasyMouseLeave(object sender, EventArgs e)
        {
            if (dif == 1)
            {
                EasyButton.FlatAppearance.BorderSize = 1;
                EasyButton.BackColor = Color.Gray;
                EasyButton.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                EasyButton.FlatAppearance.BorderSize = 0;
                EasyButton.BackColor = Color.White;
                EasyButton.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void MediumMouseLeave(object sender, EventArgs e)
        {
            if (dif == 2)
            {
                MediumButton.FlatAppearance.BorderSize = 1;
                MediumButton.BackColor = Color.Gray;
                MediumButton.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                MediumButton.FlatAppearance.BorderSize = 0;
                MediumButton.BackColor = Color.White;
                MediumButton.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void HardMouseLeave(object sender, EventArgs e)
        {
            if (dif == 3)
            {
                HardButton.FlatAppearance.BorderSize = 1;
                HardButton.BackColor = Color.Gray;
                HardButton.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                HardButton.FlatAppearance.BorderSize = 0;
                HardButton.BackColor = Color.White;
                HardButton.FlatAppearance.BorderColor = Color.White;
            }
        }

    }
}
