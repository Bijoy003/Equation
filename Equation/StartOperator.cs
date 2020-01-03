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
    public partial class StartOperator : Form
    {
        public int dif, mod;
        Random rand = new Random();
        public StartOperator(int di,int mo)
        {
            InitializeComponent();
            dif = di;
            mod = mo;
            setEquation();
            timer1.Start();
        }


        int a = 28, b = 5, c =3 , op1 = 4, op2 = 4 , res;
        int speed = 2;
        private void StartOperator_Load(object sender, EventArgs e)
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

        private void Done_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text, s2 = textBox2.Text;
            int c1 = FindOperator(s1);
            int c2 = FindOperator(s2);
            if ((s1.Length > 1) || (s2.Length > 1) || (s1 != "+" && s1 != "-" && s1 != "*" && s1 != "/") || (s2 != "+" && s2 != "-" && s2 != "*" && s2 != "/"))
            {
                inform.Text = "Invalid operator";
                inform.ForeColor = Color.OrangeRed;
            }
            else if (res == CalculateResult(a, c1, b, c2, c))
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


        //op1 = operator1 && op2 = operator2 which are unknown to user
        // + = 1 
        // - = 2
        // * = 3
        // / = 4

        void setEquation()
        {
            //initialize the values here

            a = rand.Next(1, 10);
            b = rand.Next(1, 10);
            c = rand.Next(1, 10);
            op1 = rand.Next(1, 5);
            op2 = rand.Next(1, 5);
            //MessageBox.Show(a.ToString());

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

            FirstVariable.Text = a.ToString();
            SecondVariable.Text = b.ToString();
            ThirdVariable.Text = c.ToString();
            Result.Text = res.ToString();
            inform.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
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


    }
}
