using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            // Form setup and initialization code
            this.Text = "Simple Calculator";
            this.Width = 300;
            this.Height = 400;

            // Add UI elements (buttons, textboxes, etc.)
            TextBox displayBox = new TextBox();
            displayBox.Name = "displayBox";
            displayBox.Width = 280;
            displayBox.Height = 50;
            displayBox.Top = 20;
            displayBox.Left = 10;
            displayBox.ReadOnly = true;
            this.Controls.Add(displayBox);

            Button button1 = new Button();
            button1.Name = "button1";
            button1.Text = "1";
            button1.Width = 50;
            button1.Height = 50;
            button1.Top = 100;
            button1.Left = 10;
            button1.Click += NumberButtonClick;
            this.Controls.Add(button1);

            // Add more buttons for other numbers, operators, and functions

            // You can customize and expand this according to your needs
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Handle the click event for number buttons
                TextBox? displayBox = this.Controls["displayBox"] as TextBox;
                if (displayBox != null)
                {
                    displayBox.Text += clickedButton.Text;
                }
            }
        }

        // Add similar methods for operator buttons, equals button, clear button, etc.

        // Main method to run the application
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
