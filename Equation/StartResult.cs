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
    public partial class StartResult : Form
    {
        public int dif, mod;
        public StartResult(int di,int mo)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
