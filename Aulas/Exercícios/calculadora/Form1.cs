using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        string num1, num2;
        string op="";
        decimal igual, nu1, nu2;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c_Click(object sender, EventArgs e)
        {
            result.Text = "";
            num1 = "";
            num2 = "";
            op = "";
            nu1 = 0;
            nu2 = 0;
            igual = 0;

        }   

        public void n2_Click(object sender, EventArgs e)
        {
            if(igual == 0)
            {
                if (op == "")
                {
                    num1 += n2.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n2.Text;
                    result.Text = num2;

                }
            }
            else {
                num2 += n2.Text;
                result.Text = num2;
            }
            

        }

        public void n3_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n3.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n3.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n3.Text;
                result.Text = num2;

            }
        }
        public void n4_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n4.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n4.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n4.Text;
                result.Text = num2;

            }
        
        }
    
        public void n5_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n5.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n5.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n5.Text;
                result.Text = num2;

            }
        }

        public void n6_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n6.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n6.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n6.Text;
                result.Text = num2;

            }
        }

        public void n7_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n7.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n7.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n7.Text;
                result.Text = num2;

            }
        }

        public void n8_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n8.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n8.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n8.Text;
                result.Text = num2;

            }
        }

        public void n9_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n9.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n9.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n9.Text;
                result.Text = num2;

            }
        }

        public void n0_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n0.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n0.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n0.Text;
                result.Text = num2;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            result.Text += add.Text;
            op = add.Text;
            num2 = "";

        }

        private void sub_Click(object sender, EventArgs e)
        {
            result.Text += sub.Text;
            op = sub.Text;
            num2 = "";
            
        }

        private void mult_Click(object sender, EventArgs e)
        {
            result.Text += mult.Text;
            op = mult.Text;
            num2 = "";
            
        }

        private void div_Click(object sender, EventArgs e)
        {
            result.Text += div.Text;
            op = div.Text;
            num2 = "";
            
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                if (op == "")
                {
                    num1 += n1.Text;
                    result.Text = num1;
                }
                else
                {
                    num2 += n1.Text;
                    result.Text = num2;

                }
            }
            else
            {
                num2 += n1.Text;
                result.Text = num2;

            }

        }
        public void i_Click(object sender, EventArgs e)
        {
            if (num1 == "" || num2 == "" && op != "")
            {
                result.Text = "ERRO!";
            }
            else
            {
                nu1 = decimal.Parse(num1);
                nu2 = decimal.Parse(num2);

                if (op == "+")
                {
                    if(igual == 0)
                    {
                        igual = nu1 + nu2;
                        result.Text = Convert.ToString(igual);
                    }
                    else
                    {
                        igual += nu2;
                        result.Text = Convert.ToString(igual);
                    }
                    
                }
                else if (op == "*")
                {
                    if (igual == 0)
                    {
                        igual = nu1 * nu2;
                        result.Text = Convert.ToString(igual);
                    }
                    else
                    {
                        igual *= nu2;
                        result.Text = Convert.ToString(igual);
                    }
                }
                else if (op == "/")
                {
                    if (nu2 != 0)
                    {
                        if (igual == 0)
                        {
                            igual = nu1 / nu2;
                            result.Text = Convert.ToString(igual);
                        }
                        else
                        {
                            igual /= nu2;
                            result.Text = Convert.ToString(igual);
                        }
                    }
                    else
                    {
                        result.Text = "Erro: não é possivel div. um nº por 0";
                    }
                }
                else if (op == "-")
                {
                    if (igual == 0)
                    {
                        igual = nu1 - nu2;
                        result.Text = Convert.ToString(igual);
                    }
                    else
                    {
                        igual -= nu2;
                        result.Text = Convert.ToString(igual);
                    }
                }
                else
                {
                    result.Text = "Erro!";
                }

            }
        }
    }
}
