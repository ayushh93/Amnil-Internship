namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double firstNumber, secondNumber;
        char operation;
        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "0";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Result.Text);
            operation = '+';
            Result.Text = "";

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Result.Text);
            operation = '-';
            Result.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Result.Text);
            operation = '/';
            Result.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(Result.Text);
            operation = '*';
            Result.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(Result.Text);
            double result = CalculateResult(firstNumber, secondNumber, operation);
            Result.Text = result.ToString();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            if (!Result.Text.Contains("."))
            {
                Result.Text = Result.Text + ".";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            string currentText = Result.Text;
            if (currentText.Length > 0)
            {
                Result.Text = currentText.Substring(0, currentText.Length - 1);
            }
        }

        private double CalculateResult(double firstNumber, double secondNumber, char operation)
        {
            var result = operation switch
            {
                '+' => firstNumber + secondNumber,
                '-' => firstNumber - secondNumber,
                '*' => firstNumber * secondNumber,
                '/' => (secondNumber == 0) ? 0 : firstNumber / secondNumber,
                _ => 0
            };
            return result;
        }
    }
}