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
    public partial class Loading : Form
    {
        public int dif=1,mod=1;
        public Loading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new MainMenu(dif,mod);
            this.Hide();
            f.Show();
        }
    }
}
