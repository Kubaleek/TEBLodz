namespace CalculatorMaui
{
    public partial class MainPage : ContentPage
    {
 
        public MainPage()
        {
            InitializeComponent();
        }

        private string currentValue = "0";
        private string previousValue = "0";
        private string mathOperator;


        // Działajace 
        public void HandleClearAll(object sender, EventArgs e)
        {
            currentValue = "0";
            previousValue = "0";
            mathOperator = string.Empty;
            numResult.Text = currentValue;
        }

        public void HandleClear(object sender, EventArgs e)
        {
            if (currentValue.Length > 1)
            {
                currentValue = currentValue[..^1]; // Gdy używamy Backpase usuwa ostatnia index ( -1 )
            }
            else
            {
                currentValue = "0";
            }

            numResult.Text = currentValue;
        } 
        public void ButtonClickedHandle(object sender, EventArgs e)
        {

            if(sender is Button button)
            {
                string buttonText = button.Text;

                if (currentValue == "0")
                {
                    currentValue = buttonText;
                } else
                {
                    currentValue += buttonText;
                }

                numResult.Text = currentValue;

            }
        }

        // Do Poprawienia
        public void HandleOperators(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (currentValue != "0")
                {
                    previousValue = currentValue;
                    mathOperator = button.Text;

                    numResult.Text = previousValue + " " + mathOperator;
                    currentValue = "0";
                }
                else
                {
                    mathOperator = button.Text;
                    numResult.Text = previousValue + " " + mathOperator;
                }
            }
        }

        public void HandleResult(object sender, EventArgs e)
        {
            if(mathOperator != null)
            {
                int num1 = int.Parse(previousValue);
                int num2 = int.Parse(currentValue);
                int result = 0;

                switch (mathOperator)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                    break;
                    case "*":
                        result = num1 * num2;
                    break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            numResult.Text = "Error";
                            return;
                        }
                   break;
                }

                currentValue = result.ToString();
                mathOperator = string.Empty;
                numResult.Text = currentValue;
            }
        }

    }

}
