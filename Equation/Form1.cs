using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Equation
{
    public partial class Loading : Form
    {
        public int dif=1,mod=1;
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            var f = new MainMenu(dif,mod);
            this.Hide();
            f.Show();
        }*/

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        int direction = 0 , sp = 1;

        int loading = 0 , cnt = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (loading == 58 && cnt<6)
            {
                cnt++;
            }
            else
            {
                if (loading >= 100)
                {
                    if (loading > 100) loading = 100;
                    if (cnt < 6)
                    {
                        label1.Text = "Loading " + loading.ToString() + "%";
                        cnt++;
                    }
                    else
                    {
                        var f = new MainMenu(dif, mod);
                        this.Hide();
                        f.Show();
                    }
                }
                else
                {
                    cnt = 0;
                    loading = loading + 1;
                    if (loading > 58) loading++;
                    label1.Text = "Loading " + loading.ToString() + "%";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int diff = (int)(pictureBox2.Location.Y - pictureBox3.Location.Y) - 58;
            diff = 140 - diff;
            
            if (diff < 0) diff = 0;

            sp = ((int)diff / 14) + 1;
            if (direction == 0)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + sp);
                if (pictureBox2.Location.Y - pictureBox3.Location.Y < 58)
                {
                    if (pictureBox2.Location.Y < 304) {
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + sp);
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + sp);
                    }

                    direction = 1 - direction;
                }
            }
            else
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - sp);
                if (pictureBox2.Location.Y - pictureBox3.Location.Y >198)
                {
                    direction = 1 - direction;
                }
            }
        }
    }
}
