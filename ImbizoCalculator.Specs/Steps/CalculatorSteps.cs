using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using White.Core;
using White.Core.Factory;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace ImbizoCalculator.Specs.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private Window _calculatorWindow;

        [After]
        public void CloseWindow()
        {
            _calculatorWindow.Close();
        }

        [Given(@"I have started the calculator")]
        public void GivenIHaveStartedTheCalculator()
        {
            StartCalculator();
        }

        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(string amount)
        {
            StartCalculator();
            Enter(amount);
        }

        [Given(@"I have already performed a calculation")]
        public void GivenIHaveAlreadyPerformedACalculation()
        {
            StartCalculator();
            Enter("1+1=");
        }

        private void StartCalculator()
        {
            var application = Application.Launch("ImbizoCalculator.exe");
            _calculatorWindow = application.GetWindow("Calculator", InitializeOption.NoCache);
        }

        [When(@"I press (.*)")]
        public void WhenIPress(string buttons)
        {
            Enter(buttons);
        }

        [When(@"I add (\d*) and clear it")]
        public void WhenIAddAndClearIt(string amount)
        {
            Add(amount);
            PressButton("CE");
        }

        [When(@"I add (\d*)")]
        public void WhenIAdd(string amount)
        {
            Add(amount);
        }

        [When(@"I clear the calculation")]
        public void WhenIClearTheCalculation()
        {
            PressButton("CA");
        }

        [When(@"I add the following amounts")]
        public void WhenIAddTheFollowingAmounts(Table table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                string amount = row.GetString("amount");

                if (i > 0)
                {
                    Add(amount);
                }
                else
                {
                    Enter(amount);                    
                }
            }
        }

        [When(@"I continue to add the following amounts")]
        public void WhenIContinueToAddTheFollowingAmounts(Table table)
        {
            foreach (var row in table.Rows)
            {
                Add(row.GetString("amount"));
            }
        }

        [When(@"I subtract (.*)")]
        public void WhenISubtract(string amount)
        {
            Subtract(amount);
        }

        [When(@"I multiply (.*) by (.*)")]
        public void WhenIMultiplyBy(string first, string second)
        {
            Enter(first);
            MultiplyBy(second);
        }

        [When(@"I divide (.*) by (.*)")]
        public void WhenIDivideBy(string first, string second)
        {
            Enter(first);
            DivideBy(second);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(string number)
        {
            PressEquals();
            Assert.AreEqual(number, NumberOnScreen());
        }

        private void Add(string amount)
        {
            Enter("+");
            Enter(amount);
        }

        private void Subtract(string amount)
        {
            Enter("-");
            Enter(amount);
        }

        private void MultiplyBy(string amount)
        {
            Enter("*");
            Enter(amount);
        }

        private void DivideBy(string amount)
        {
            Enter("/");
            Enter(amount);
        }

        private void PressEquals()
        {
            Enter("=");
        }

        private string NumberOnScreen()
        {
            var calculatorScreen = _calculatorWindow.Get<TextBox>("calculatorScreen");
            return calculatorScreen.Text;
        }

        private void Enter(string buttons)
        {
            foreach (char button in buttons)
            {
                PressButton(button.ToString());
            }
        }

        private void PressButton(string buttonText)
        {
            var button = _calculatorWindow.Get<Button>(SearchCriteria.ByText(buttonText));
            button.Click();
        }
    }
}
