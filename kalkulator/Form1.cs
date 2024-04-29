using System.Diagnostics;
using System.Linq.Expressions;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string option;
        double result = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                display.Text += button.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Text = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = double.Parse(display.Text);
                display.Text = string.Empty;

                switch (option)
                {
                    case "+":
                        result = num1 + num2; break;
                    case "-":
                        result = num1 - num2; break;
                    case "*":
                        result = num1 * num2; break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                        }
                        break;
                    case "":
                        throw new Exception();
                }

                display.Text = $"{result}";
                option = "";
            }

            catch
            {
                MessageBox.Show("Please enter a number and operator first.");
                display.Text = String.Empty;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;

                try
                {
                    option = button.Text;
                    num1 = double.Parse(display.Text);
                    display.Text = string.Empty;
                }
                catch
                {
                    MessageBox.Show("Please enter a number first.");
                }

            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = double.Parse(display.Text);
                temp *= (-1);
                display.Text = temp.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a number first.");
            }
        }
    }
}