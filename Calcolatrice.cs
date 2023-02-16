namespace Calculator
{
    public partial class Calcolatrice : Form
    {
        //Fields
        private string lastOperation = ".";
        private double? result;
        private bool isResult;
        private double firstInput;
        private double lastInput;

        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void btn_NumPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Invoke((MethodInvoker)delegate
            {
                if (isResult)
                {
                    isResult = false;
                    txtResult.Text = "0";
                }
                if (txtResult.Text.Length == 1 && txtResult.Text == "0") txtResult.Text = btn.Text;
                else txtResult.Text += btn.Text;
            });
            
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!txtResult.Text.Contains(btn.Text))
            {
           
                txtResult.Text = txtResult.Text + btn.Text;
            }
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtResult.Text != "0")
                if (txtResult.Text.ElementAt(0) == '-') txtResult.Text = txtResult.Text.Remove(0,1);
                else txtResult.Text = "-" + txtResult.Text; 
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double square = Math.Pow(Double.Parse(txtResult.Text), 2);
            txtHistory.Text = $"sqr( {txtResult.Text} )";
            txtResult.Text = square.ToString();
            
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtHistory.Text = "";
            result = null;
            isResult = false;
            lastOperation = ".";
            lastInput = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isResult)
            {
                if(txtResult.Text.Length > 1) txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
                else txtResult.Text = "0";
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            // Case: User chooses a different operation
            if (isResult)
            {
                lastOperation = button.Text;
                txtHistory.Text = $"{firstInput} {lastOperation}";
                return;
            }

            // Case: No history
            if (txtHistory.Text == string.Empty)
            {
                firstInput = Double.Parse(txtResult.Text);
                lastOperation = button.Text;
                txtHistory.Text = $"{firstInput} {lastOperation}";
                isResult = true;
            }
            
            // Case: History -> First input and last operation are defined
            else
            {
    
                lastInput = Double.Parse(txtResult.Text);

                double result = getResult();

                lastOperation = button.Text;
                txtHistory.Text = $"{result.ToString()} {lastOperation}";
                txtResult.Text = result.ToString();
                firstInput = result;
                isResult = true;
            }
            
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Case: History -> First input and last operation are defined
            if(txtHistory.Text != string.Empty)
            {
                lastInput = isResult ? lastInput : Double.Parse(txtResult.Text);
                double result = getResult();

                // Last Operation non cambia
                txtHistory.Text = $"{firstInput} {lastOperation} {lastInput} = {result}";
                txtResult.Text = result.ToString();
                firstInput = result;
                isResult = true;
            }
        }

        private double getResult()
        {
            switch (lastOperation)
            {
                case "+":
                    return firstInput + lastInput;
                case "-":
                    return firstInput - lastInput;
                case "*":
                    return firstInput * lastInput;
                case "/":
                    return firstInput / lastInput;
                default:
                    return 0;
            };
        }
    }
}