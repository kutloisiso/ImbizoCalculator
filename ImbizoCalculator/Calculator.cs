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
            DisplayOnScreen(0);
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
                    _currentResult = EnteredNumber();
                    break;
                case CalculatorOperation.Add:
                    _currentResult += EnteredNumber();
                    break;
                case CalculatorOperation.Subtract:
                    _currentResult -= EnteredNumber();
                    break;
                case CalculatorOperation.Multiply:
                    _currentResult *= EnteredNumber();
                    break;
                case CalculatorOperation.Divide:
                    _currentResult /= EnteredNumber();
                    break;
            }

            DisplayOnScreen(_currentResult);
        }

        private double EnteredNumber()
        {
            return double.Parse(calculatorScreen.Text);
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            if (_clearScreenOnNextDigit)
            {
                ClearScreen();
            }

            string digit = ((Button) sender).Text;
            calculatorScreen.Text += digit;
        }

        private void ClearScreen()
        {
            calculatorScreen.Text = string.Empty;
            _clearScreenOnNextDigit = false;
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            DisplayOnScreen(0);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            _currentResult = 0;
            DisplayOnScreen(0);
        }

        private void DisplayOnScreen(double value)
        {
            calculatorScreen.Text = value.ToString();
            _clearScreenOnNextDigit = true;
        }
    }
}
