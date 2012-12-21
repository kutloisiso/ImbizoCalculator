using System;
using System.Windows.Forms;

namespace ImbizoCalculator
{
    public partial class Calculator : Form
    {
        private enum CalculatorOperation
        {
            Nothing,
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private CalculatorOperation _currentOperation = CalculatorOperation.Nothing;
        private double _currentResult;
        private bool _clearScreenOnNextDigit;

        public Calculator()
        {
            InitializeComponent();
            calculatorScreen.Text = "0";
            _clearScreenOnNextDigit = true;
        }

        private double NumberOnScreen
        {
            get { return double.Parse(calculatorScreen.Text); }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            PerformCurrentOperation();
            _currentResult = 0;
            _currentOperation = CalculatorOperation.Nothing;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PerformCurrentOperation();
            _currentOperation = CalculatorOperation.Add;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            PerformCurrentOperation();
            _currentOperation = CalculatorOperation.Subtract;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            PerformCurrentOperation();
            _currentOperation = CalculatorOperation.Multiply;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            PerformCurrentOperation();
            _currentOperation = CalculatorOperation.Divide;
        }

        private void PerformCurrentOperation()
        {
            switch (_currentOperation)
            {
                case CalculatorOperation.Nothing:
                    _currentResult = NumberOnScreen;
                    break;
                case CalculatorOperation.Add:
                    _currentResult += NumberOnScreen;
                    break;
                case CalculatorOperation.Subtract:
                    _currentResult -= NumberOnScreen;
                    break;
                case CalculatorOperation.Multiply:
                    _currentResult *= NumberOnScreen;
                    break;
                case CalculatorOperation.Divide:
                    _currentResult /= NumberOnScreen;
                    break;
            }

            calculatorScreen.Text = _currentResult.ToString();
            _clearScreenOnNextDigit = true;
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            if (_clearScreenOnNextDigit)
            {
                calculatorScreen.Text = string.Empty;
                _clearScreenOnNextDigit = false;
            }

            calculatorScreen.Text += ((Button) sender).Text;
        }
    }
}
