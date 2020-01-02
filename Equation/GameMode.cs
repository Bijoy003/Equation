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
        public GameMode()
        {
            InitializeComponent();
        }
        public string Mode = "MissingOperator";

        public string getMode()
        {
            return Mode;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mode = "MissingOperator";
            var f = new MainMenu();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode = "MissingVariable";
            var f = new MainMenu();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mode = "MissingResult";
            var f = new MainMenu();
            this.Hide();
            f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new MainMenu();
            this.Hide();
            f.Show();
        }
    }
}
