namespace DotinProjects.WinAppSimpleCalculator
{
    public partial class Form1 : Form
    {
        private double FirstNumber;
        private string Operation;

        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            // Attach event handlers to buttons
            n1.Click += NumberButton_Click;
            n2.Click += NumberButton_Click;
            n3.Click += NumberButton_Click;
            n4.Click += NumberButton_Click;
            n5.Click += NumberButton_Click;
            n6.Click += NumberButton_Click;
            n7.Click += NumberButton_Click;
            n8.Click += NumberButton_Click;
            n9.Click += NumberButton_Click;
            n0.Click += NumberButton_Click;

            // Other event handlers
            bad.Click += OperatorButton_Click;
            bsub.Click += OperatorButton_Click;
            bmult.Click += OperatorButton_Click;
            bdiv.Click += OperatorButton_Click;

            bc.Click += ClearButton_Click;
            ndot.Click += DotButton_Click;
            bequal.Click += EqualButton_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateTextBoxValue(button.Text);
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            if (double.TryParse(textBox1.Text, out secondNumber))
            {
                switch (Operation)
                {
                    case "+":
                        result = FirstNumber + secondNumber;
                        break;
                    case "-":
                        result = FirstNumber - secondNumber;
                        break;
                    case "*":
                        result = FirstNumber * secondNumber;
                        break;
                    case "/":
                        result = secondNumber != 0 ? FirstNumber / secondNumber : double.NaN;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }

                textBox1.Text = result.ToString();
                FirstNumber = result;
            }
            else
            {
                textBox1.Text = "Invalid input";
            }
        }

        private void UpdateTextBoxValue(string value)
        {
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero" || textBox1.Text == "Invalid input")
            {
                textBox1.Text = value;
            }
            else
            {
                textBox1.Text += value;
            }
        }
    }
}
