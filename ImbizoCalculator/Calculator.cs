using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImbizoCalculator
{
    public partial class Calculator : Form
    {
        private readonly List<int> _numbers = new List<int>();
        private bool _clearScreenOnNextDigit;

        public Calculator()
        {
            InitializeComponent();
        }

        private int NumberOnScreen
        {
            get { return int.Parse(calculatorScreen.Text); }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            int result = _numbers[0] + NumberOnScreen;
            calculatorScreen.Text = result.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _numbers.Add(NumberOnScreen);
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
