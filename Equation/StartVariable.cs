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
    public partial class StartVariable : Form
    {
        Random rand = new Random();
        public StartVariable(int di, int mo)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
            timer1.Start();
            setEquation();
        }

        int dif, mod,speed = 2;
        int a = 28, b = 5, c = 3, op1 = 4, op2 = 4, res;

        private void StartVariable_Load(object sender, EventArgs e)
        {

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

        private void Done_MouseLeave(object sender, EventArgs e)
        {
            Done.FlatAppearance.BorderSize = 3;
            Done.BackColor = Color.White;
            Done.FlatAppearance.BorderColor = Color.Green;
        }

        private void Done_MouseEnter(object sender, EventArgs e)
        {
            Done.FlatAppearance.BorderSize = 0;
            Done.BackColor = Color.SkyBlue;
        }

        private void Done_Click_1(object sender, EventArgs e)
        {
            int _aa = Int32.Parse(firstVariable.Text);
            int _cc = Int32.Parse(thirdVariable.Text);
           
            /*if ((s1.Length > 1) || (s2.Length > 1) || (s1 != "+" && s1 != "-" && s1 != "*" && s1 != "/") || (s2 != "+" && s2 != "-" && s2 != "*" && s2 != "/"))
            {
                inform.Text = "Invalid operator";
                inform.ForeColor = Color.OrangeRed;
            }
            */
            if (res == CalculateResult(_aa, op1, b, op2, _cc))
            {
                //score count
                int sc = Int32.Parse(Score.Text);
                sc++;
                Score.Text = sc.ToString();
                //

                //Refresh Time
                speed += 2;
                pictureBox1.Location = new Point(-932, 44);
                //

                setEquation();
            }
            else
            {
                inform.Text = "Wrong answer, Try Again";
                inform.ForeColor = Color.Red;
            }
        }

        void setEquation()
        {
            //initialize the values here

            a = rand.Next(1, 10);
            b = rand.Next(1, 10);
            c = rand.Next(1, 10);
            op1 = rand.Next(1, 5);
            op2 = rand.Next(1, 5);

            //

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
            else
            {
                res = CalculateResult(a, op1, b, op2, c);
            }

            string FindOperator(int _a)
            {
                string _s = "+";
                if (_a == 2) _s = "-";
                if (_a == 3) _s = "*";
                if (_a == 4) _s = "/";
                return _s;
            }

            secondVariable.Text = b.ToString();
            Result.Text = res.ToString();
            operation1.Text = FindOperator(op1);
            operation2.Text = FindOperator(op2);
            firstVariable.Text = "";
            thirdVariable.Text = "";

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

    }
}
