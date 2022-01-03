using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalkulatorGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal numberA, numberB;

        

        private void Add_Click(object sender, EventArgs e)
        {
            numberA = Convert.ToDecimal(InputA.Text);
            numberB = Convert.ToDecimal(InputB.Text);
            Result.Text = Convert.ToString(numberA+numberB);
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            numberA = Convert.ToDecimal(InputA.Text);
            numberB = Convert.ToDecimal(InputB.Text);
            Result.Text = Convert.ToString(numberA - numberB);
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            numberA = Convert.ToDecimal(InputA.Text);
            numberB = Convert.ToDecimal(InputB.Text);
            Result.Text = Convert.ToString(numberA * numberB);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            numberA = Convert.ToDecimal(InputA.Text);
            numberB = Convert.ToDecimal(InputB.Text);
            try
            {
                Result.Text = Convert.ToString(numberA / numberB);
            }
            catch (DivideByZeroException) {
                Result.Text = "Nie dzielimy przez 0";
            }
           
        }

        private void potegowanie_Click(object sender, EventArgs e)
        {
            decimal li1, li2;
            li1 = Convert.ToDecimal(textBox1.Text);
            //li2 = Convert.ToDecimal(textBox2.Text);
            textBox2.Text = Convert.ToString(li1 * li1);
        }
    }
}
