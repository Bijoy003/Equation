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

        }


        int a = 28, b = 5, c =3 , op1 = 4, op2 = 4 , res;

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new MainMenu(dif, mod);
            this.Hide();
            f.Show();
        }

        //op1 = operator1 && op2 = operator2 which are unknown to user
        // + = 1 
        // - = 2
        // * = 3
        // / = 4

        void setEquation()
        {
            //initialize the values here

            a = rand.Next(1,20);
            MessageBox.Show(a.ToString());

            //

            if (op2 == 4 && b % c != 0)
            {
                b += (c - b % c);
            }
            if (op1 == 4 && a % b != 0)
            {
                a += (b - a % b);
            }

            if (op1==4 && op2 == 4)
            {
                int temp = a / b;
                if (temp % c != 0)
                {
                    int rem = c - temp % c;
                    a += rem * b;
                }
                //MessageBox.Show(b.ToString());
                //MessageBox.Show(c.ToString());

                res = a / b / c;
            
                //MessageBox.Show(res.ToString());
            }
            else
            {
                int firstPart = 0, secondParet = 0;
                if (op1 == 4)
                {
                    firstPart = a / b;
                    if (op2== 4)
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
            
        }

    }
}
