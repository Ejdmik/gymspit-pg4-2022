namespace calculator
{
    public partial class Form1 : Form
    {
        double numberA = 0;
        double numberB = 0;
        int countop = 0;
        char operation = ' ';
        char[] signs = { '+', '-', '*', '÷' };
        public Form1()
        {
            InitializeComponent();
        }

        public double Compute(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;  
                case '*':
                    return a * b;
                case '÷':
                    return a / b;
                default:
                    return 69;
            }
        }
        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
                if (operation == ' ')
                {
                    numberA = 1;
                }
                else
                {
                    numberB = 1;
                }
            }
            else
            {
                textBox1.Text += "1";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 1;
                }
                else
                {
                    numberB = numberB * 10 + 1;
                }
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
                if (operation == ' ')
                {
                    numberA = 2;
                }
                else
                {
                    numberB = 2;
                }
            }
            else
            {
                textBox1.Text += "2";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 2;
                }
                else
                {
                    numberB = numberB * 10 + 2;
                }
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
                if (operation == ' ')
                {
                    numberA = 3;
                }
                else
                {
                    numberB = 3;
                }
            }
            else
            {
                textBox1.Text += "3";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 3;
                }
                else
                {
                    numberB = numberB * 10 + 3;
                }
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
                if (operation == ' ')
                {
                    numberA = 4;
                }
                else
                {
                    numberB = 4;
                }
            }
            else
            {
                textBox1.Text += "4";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 4;
                }
                else
                {
                    numberB = numberB * 10 + 4;
                }
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
                if (operation == ' ')
                {
                    numberA = 5;
                }
                else
                {
                    numberB = 5;
                }
            }
            else
            {
                textBox1.Text += "5";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 5;
                }
                else
                {
                    numberB = numberB * 10 + 5;
                }
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
                if (operation == ' ')
                {
                    numberA = 6;
                }
                else
                {
                    numberB = 6;
                }
            }
            else
            {
                textBox1.Text += "6";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 6;
                }
                else
                {
                    numberB = numberB * 10 + 6;
                }
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
                if (operation == ' ')
                {
                    numberA = 7;
                }
                else
                {
                    numberB = 7;
                }
            }
            else
            {
                textBox1.Text += "7";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 7;
                }
                else
                {
                    numberB = numberB * 10 + 7;
                }
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
                if (operation == ' ')
                {
                    numberA = 8;
                }
                else
                {
                    numberB = 8;
                }
            }
            else
            {
                textBox1.Text += "8";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 8;
                }
                else
                {
                    numberB = numberB * 10 + 8;
                }
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
                if (operation == ' ')
                {
                    numberA = 9;
                }
                else
                {
                    numberB = 9;
                }
            }
            else
            {
                textBox1.Text += "9";
                if (operation == ' ')
                {
                    numberA = numberA * 10 + 9;
                }
                else
                {
                    numberB = numberB * 10 + 9;
                }
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
                if (operation == ' ')
                {
                    numberA = numberA*10;
                }
                else
                {
                    numberB = numberB*10;
                }
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (operation == ' ')
            {
                numberA = 0;
            }
            else
            {
                numberB = 0;
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !signs.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            { 
                if (countop > 0)
                {
                    numberA = Compute(numberA, numberB, operation);
                    numberB = 0;
                }
                operation = '+';
                textBox1.Text += "+";
                countop++;
            }
        }

        private void subbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !signs.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            { 
                if (countop > 0)
                {
                    numberA = Compute(numberA, numberB, operation);
                    numberB = 0;
                }
                operation = '-';
                textBox1.Text += "-";
                countop++;
            }
        }

        private void mulbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !signs.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            { 
                if (countop > 0)
                {
                    numberA = Compute(numberA, numberB, operation);
                    numberB = 0;
                }
                operation = '*';
                textBox1.Text += "*";
                countop++;
            }
        }

        private void divbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !signs.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            { 
                if (countop > 0)
                {
                    numberA = Compute(numberA, numberB, operation);
                    numberB = 0;
                }
                operation = '÷';
                textBox1.Text += "÷";
                countop++;
            }
        }

        private void eqbutton_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                label1.Text = "Result: " + numberA.ToString();
                textBox1.Text = "";
                numberA = 0;
            }
            else
            {
                if(numberB == 0 && operation == '÷')
                {
                    label1.Text = "ERROR";
                }
                else
                {
                    label1.Text = textBox1.Text + " = " + Compute(numberA, numberB, operation).ToString();
                }
                numberA = 0;
                numberB = 0;
                operation = ' ';
                countop = 0;
                textBox1.Text = "";
            }
        }
    }
}