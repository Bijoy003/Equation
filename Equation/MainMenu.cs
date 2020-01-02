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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var f = new StartOperator();
            this.Hide();
            f.Show();
        }

        private void GameMode_Click(object sender, EventArgs e)
        {
            var f = new GameMode();
            this.Hide();
            f.Show();
        }

        private void Difficulty_Click(object sender, EventArgs e)
        {
            var f = new Difficulty();
            this.Hide();
            f.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            var f = new About();
            this.Hide();
            f.Show();
        }
    }
}
