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



        private void Start_MouseEnter(object sender, EventArgs e)
        {
            Start.FlatAppearance.BorderSize = 1;
            Start.BackColor = Color.Green;
            Start.FlatAppearance.BorderColor = Color.Green;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.FlatAppearance.BorderSize = 0;
            Start.BackColor = Color.White;
            Start.FlatAppearance.BorderColor = MainMenu.DefaultBackColor;
        }

        private void Game_Mode_MouseEnter(object sender, EventArgs e)
        {
            Game_Mode.FlatAppearance.BorderSize = 1;
            Game_Mode.BackColor = Color.Green;
            Game_Mode.FlatAppearance.BorderColor = Color.Green;
        }

        private void Difficulty_MouseEnter(object sender, EventArgs e)
        {
            Difficulty.FlatAppearance.BorderSize = 1;
            Difficulty.BackColor = Color.Green;
            Difficulty.FlatAppearance.BorderColor = Color.Green;
        }

        private void About_MouseEnter(object sender, EventArgs e)
        {
            About.FlatAppearance.BorderSize = 1;
            About.BackColor = Color.Green;
            About.FlatAppearance.BorderColor = Color.Green;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.FlatAppearance.BorderSize = 1;
            Exit.BackColor = Color.OrangeRed;
            Exit.FlatAppearance.BorderColor = Color.Green;
        }

        private void Game_Mode_MouseLeave(object sender, EventArgs e)
        {
            Game_Mode.FlatAppearance.BorderSize = 0;
            Game_Mode.BackColor = Color.White;
            Game_Mode.FlatAppearance.BorderColor = MainMenu.DefaultBackColor;
        }

        private void Difficulty_MouseLeave(object sender, EventArgs e)
        {
            Difficulty.FlatAppearance.BorderSize = 0;
            Difficulty.BackColor = Color.White;
            Difficulty.FlatAppearance.BorderColor = MainMenu.DefaultBackColor;
        }

        private void About_MouseLeave(object sender, EventArgs e)
        {
            About.FlatAppearance.BorderSize = 0;
            About.BackColor = Color.White;
            About.FlatAppearance.BorderColor = MainMenu.DefaultBackColor;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.FlatAppearance.BorderSize = 0;
            Exit.BackColor = Color.White;
            Exit.FlatAppearance.BorderColor = MainMenu.DefaultBackColor;
        }

        private void About_Click(object sender, EventArgs e)
        {
            var f = new About(dif, mod);
            this.Hide();
            f.Show();
        }
    }
}
