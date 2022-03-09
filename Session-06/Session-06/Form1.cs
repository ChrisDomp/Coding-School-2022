using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1;
        int operation;
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
        }

        private void buttonPlus(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operation = 0;
        }

        private void buttonMinus(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operation = 1;
        }

        private void buttonMultiply(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operation = 2;
        }
        private void buttonDivide(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operation = 3;
        }

        private void buttonDecimal(object sender, EventArgs e)
        {
            if(textBox1.Text==String.Empty)
                this.textBox1.Text += "0.";
            else this.textBox1.Text += ".";

        }

        private void buttonPow(object sender, EventArgs e)
        {
            //this.textBox1.Text += "^";
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operation = 4;

        }


        private void buttonSquareRoot(object sender, EventArgs e)
        {
            //this.textBox1.Text += "√";
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operation = 5;
            
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            
            float num2 = float.Parse(textBox1.Text);
            Calculator.Calc calc = new Calculator.Calc();
            double computation = calc.Compute(num1, num2, operation);
            this.textBox1.Text= Convert.ToString(computation);

        }

        private void buttonClear(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
