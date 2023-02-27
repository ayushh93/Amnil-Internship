namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CalculateResult("+");

        }

        private void btnSubtract_Click(object sender, EventArgs e)
         {
             CalculateResult("-");
         }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CalculateResult("*");

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            CalculateResult("/");

        }

        private void CalculateResult(string operation)
         {
             double firstNumber = Convert.ToDouble(FirstNumber.Text);
             double secondNumber = Convert.ToDouble(SecondNumber.Text);

            try
            {
                var result = operation switch
                {
                    "+" => firstNumber + secondNumber,
                    "-" => firstNumber - secondNumber,
                    "*" => firstNumber * secondNumber,
                    "/" => firstNumber / secondNumber,
                    _ => 0
                };
                if (result == 0)
                    Result.Text = "Invalid";
                else
                    Result.Text = result.ToString();

                var formattedOutput = $"{firstNumber} {operation} {secondNumber} = {result}";

                MessageBox.Show(formattedOutput, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
         }

        
    }
    }