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
        public Difficulty()
        {
            InitializeComponent();
        }

        public string Diffi;

        public string getDifficulty()
        {
            return Diffi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diffi = "Easy";
            var f = new MainMenu();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Diffi = "Medium";
            var f = new MainMenu();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Diffi = "Hard";
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
