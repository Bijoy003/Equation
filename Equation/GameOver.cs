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
    public partial class GameOver : Form
    {
        int dif, mod, score;
        public GameOver(int di , int mo, int sc)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
            score = sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
