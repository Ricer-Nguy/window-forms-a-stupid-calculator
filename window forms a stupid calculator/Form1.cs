namespace window_forms_a_stupid_calculator
{
    public partial class Calculator : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        // Handles digit button clicks (0-9)
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBoxDisplay.Text += btn.Text;
        }

        // Handles operation button clicks (+, -, *, /)
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (double.TryParse(textBoxDisplay.Text, out firstNumber))
            {
                operation = btn.Text;
                textBoxDisplay.Clear();
            }
        }

        // Handles equals button click (=)
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDisplay.Text, out secondNumber))
            {
                double result = 0;
                switch (operation)
                {
                    case "+": result = firstNumber + secondNumber; break;
                    case "-": result = firstNumber - secondNumber; break;
                    case "*": result = firstNumber * secondNumber; break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            textBoxDisplay.Text = "Cannot divide by zero";
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                }
                textBoxDisplay.Text = result.ToString();
            }
        }

        // Handles clear button click (C)
        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        // Handles square root button click (√)
        private void SqrtButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDisplay.Text, out double num))
                textBoxDisplay.Text = Math.Sqrt(num).ToString();
        }

        // Handles percent button click (%)
        private void PercentButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDisplay.Text, out double num))
                textBoxDisplay.Text = (num / 100).ToString();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
           
        }
    }
}