using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        double firstNumber;
        string operation;
        public Calc()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void Multiply(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "*";
            txtDisplay.Clear();
        }

        private void Divide(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "/";
            txtDisplay.Clear();
        }

        private void Clear(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNumber = 0;
            operation = "";
        }

        private void Add(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "+";
            txtDisplay.Clear();
        }

        private void Subtract(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "-";
            txtDisplay.Clear();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        } 
        private void Decimal(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void Equal(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
            }
           
            txtDisplay.Text = result.ToString();
        }

        private void Backspace(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(
                    0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

       
    }
}
