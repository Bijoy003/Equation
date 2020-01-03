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
            if(mod==1)
            {
                MissingOperator.FlatAppearance.BorderSize = 1;
                MissingOperator.BackColor = Color.Gray;
                MissingOperator.FlatAppearance.BorderColor = Color.Gray;
            }
            else if(mod==2)
            {
                MissingVariable.FlatAppearance.BorderSize = 1;
                MissingVariable.BackColor = Color.Gray;
                MissingVariable.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                MissingResult.FlatAppearance.BorderSize = 1;
                MissingResult.BackColor = Color.Gray;
                MissingResult.FlatAppearance.BorderColor = Color.Gray;
            }
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

        private void GameMode_Load(object sender, EventArgs e)
        {

        }

        private void OperatorMouseEnter(object sender, EventArgs e)
        {
            MissingOperator.FlatAppearance.BorderSize = 1;
            MissingOperator.BackColor = Color.Green;
            MissingOperator.FlatAppearance.BorderColor = Color.Green;
        }

        private void VariableMouseEnter(object sender, EventArgs e)
        {
            MissingVariable.FlatAppearance.BorderSize = 1;
            MissingVariable.BackColor = Color.Green;
            MissingVariable.FlatAppearance.BorderColor = Color.Green;
        }

        private void ResultMouseEnter(object sender, EventArgs e)
        {
            MissingResult.FlatAppearance.BorderSize = 1;
            MissingResult.BackColor = Color.Green;
            MissingResult.FlatAppearance.BorderColor = Color.Green;
        }

        private void OperatorMouseLeave(object sender, EventArgs e)
        {
            if (mod == 1)
            {
                MissingOperator.FlatAppearance.BorderSize = 1;
                MissingOperator.BackColor = Color.Gray;
                MissingOperator.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                MissingOperator.FlatAppearance.BorderSize = 0;
                MissingOperator.BackColor = Color.White;
                MissingOperator.FlatAppearance.BorderColor = GameMode.DefaultBackColor;
            }
        }

        private void VariableMouseLeave(object sender, EventArgs e)
        {
            if (mod == 2)
            {
                MissingVariable.FlatAppearance.BorderSize = 1;
                MissingVariable.BackColor = Color.Gray;
                MissingVariable.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                MissingVariable.FlatAppearance.BorderSize = 0;
                MissingVariable.BackColor = Color.White;
                MissingVariable.FlatAppearance.BorderColor = GameMode.DefaultBackColor;
            }
        }

        private void ResultMouseLeave(object sender, EventArgs e)
        {
            if (mod == 3)
            {
                MissingResult.FlatAppearance.BorderSize = 1;
                MissingResult.BackColor = Color.Gray;
                MissingResult.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                MissingResult.FlatAppearance.BorderSize = 0;
                MissingResult.BackColor = Color.White;
                MissingResult.FlatAppearance.BorderColor = GameMode.DefaultBackColor;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new MainMenu(dif, mod);
            this.Hide();
            f.Show();
        }
    }
}
