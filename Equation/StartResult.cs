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
        Random rand = new Random();
        int a = 28, b = 5, c = 3, op1 = 4, op2 = 4, res;
        int speed = 2;
        public StartResult(int di,int mo)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
            setEquation();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new MainMenu(dif, mod);
            this.Hide();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + speed, pictureBox1.Location.Y);
            if (pictureBox1.Location.X > -12)
            {
                timer1.Stop();
                GameOver g = new GameOver(dif, mod, Int32.Parse(Score.Text));
                this.Hide();
                g.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            int  res = Int32.Parse(Result.Text);
            if (res == CalculateResult(a, op1, b, op2, c))
            {
                //score count
                int sc = Int32.Parse(Score.Text);
                sc++;
                Score.Text = sc.ToString();
                //
                //Refresh Time
                speed += 2;
                pictureBox1.Location = new Point(-1044, 44);
                //
                setEquation();
            }
            else
            {
                inform.Text = "Wrong answer, Try Again";
                inform.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void setEquation()
        {
            //initialize the values here

            a = rand.Next(1, 10);
            b = rand.Next(1, 10);
            c = rand.Next(1, 10);
            op1 = rand.Next(1, 5);
            op2 = rand.Next(1, 5);
            //MessageBox.Show(a.ToString());

            if (op2 == 4 && b % c != 0)
            {
                b += (c - b % c);
            }
            if (op1 == 4 && a % b != 0)
            {
                a += (b - a % b);
            }

            if (op1 == 4 && op2 == 4)
            {
                int temp = a / b;
                if (temp % c != 0)
                {
                    int rem = c - temp % c;
                    a += rem * b;
                }
                //MessageBox.Show(b.ToString());
                //MessageBox.Show(c.ToString());

                res = CalculateResult(a, op1, b, op2, c);

                //MessageBox.Show(res.ToString());
            }

            FirstVariable.Text = a.ToString();
            SecondVariable.Text = b.ToString();
            ThirdVariable.Text = c.ToString();
            FirstOperand.Text = FindOperand(op1);
            SecondOperand.Text = FindOperand(op2);
            Result.Text = "";
            inform.Text = "";
        }

        int CalculateResult(int aa, int oop1, int bb, int oop2, int cc)
        {
            int firstPart = 0, secondParet = 0, rres = 0;
            if (oop1 == 4)
            {
                firstPart = aa / bb;
                if (oop2 == 4)
                {
                    rres = firstPart / cc;
                }
                if (oop2 == 3)
                {
                    rres = firstPart * cc;
                }
                if (oop2 == 2)
                {
                    rres = firstPart - cc;
                }
                if (oop2 == 1)
                {
                    rres = firstPart + cc;
                }
            }
            else if (oop1 == 3)
            {
                firstPart = aa * bb;
                if (oop2 == 4)
                {
                    rres = firstPart / cc;
                }
                if (oop2 == 3)
                {
                    rres = firstPart * cc;
                }
                if (oop2 == 2)
                {
                    rres = firstPart - cc;
                }
                if (oop2 == 1)
                {
                    rres = firstPart + cc;
                }
            }
            else if (oop2 == 4)
            {
                secondParet = bb / cc;
                if (oop1 == 4)
                {
                    rres = aa / secondParet;
                }
                if (oop1 == 3)
                {
                    rres = aa * secondParet;
                }
                if (oop1 == 2)
                {
                    rres = aa - secondParet;
                }
                if (oop1 == 1)
                {
                    rres = aa + secondParet;
                }
            }
            else if (oop2 == 3)
            {
                secondParet = bb * cc;
                if (oop1 == 4)
                {
                    rres = aa / secondParet;
                }
                if (oop1 == 3)
                {
                    rres = aa * secondParet;
                }
                if (oop1 == 2)
                {
                    rres = aa - secondParet;
                }
                if (oop1 == 1)
                {
                    rres = aa + secondParet;
                }
            }
            else
            {
                if (oop1 == 1)
                {
                    firstPart = aa + bb;
                    if (oop2 == 1) rres = firstPart + cc;
                    else rres = firstPart - cc;
                }
                if (oop1 == 2)
                {
                    firstPart = aa - bb;
                    if (oop2 == 1) rres = firstPart + cc;
                    else rres = firstPart - cc;
                    firstPart = a / b;
                    if (op2 == 4)
                    {
                        res = firstPart / c;
                    }
                    if (op2 == 3)
                    {
                        res = firstPart * c;
                    }
                    if (op2 == 2)
                    {
                        res = firstPart - c;
                    }
                    if (op2 == 1)
                    {
                        res = firstPart * c;
                    }
                }
                if (op1 == 3)
                {
                    firstPart = a * b;
                    if (op2 == 4)
                    {
                        res = firstPart / c;
                    }
                    if (op2 == 3)
                    {
                        res = firstPart * c;
                    }
                    if (op2 == 2)
                    {
                        res = firstPart - c;
                    }
                    if (op2 == 1)
                    {
                        res = firstPart * c;
                    }
                }
                if (op2 == 4)
                {
                    secondParet = b / c;
                    if (op1 == 4)
                    {
                        res = a / firstPart;
                    }
                    if (op1 == 3)
                    {
                        res = a * firstPart;
                    }
                    if (op1 == 2)
                    {
                        res = a - firstPart;
                    }
                    if (op1 == 1)
                    {
                        res = a + firstPart;
                    }
                }

            }

            return rres;
        }

        int FindOperator(string s)
        {
            int ret = 1;
            if (s == "-") ret = 2;
            if (s == "*") ret = 3;
            if (s == "/") ret = 4;

            return ret;
        }

        String FindOperand(int a)
        {
            string c;
            if (a == 1) c = "+";
            else if (a == 2) c = "-";
            else if (a == 3) c = "*";
            else c = "/";

            return c;
        }

    }
}
