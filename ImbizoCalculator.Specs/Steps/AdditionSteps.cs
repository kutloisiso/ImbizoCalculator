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
    public class AdditionSteps
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
            var application = Application.Launch("ImbizoCalculator.exe");
            _calculatorWindow = application.GetWindow("Calculator", InitializeOption.NoCache);
        }

        [Given(@"I have already performed a calculation")]
        public void GivenIHaveAlreadyPerformedACalculation()
        {
            GivenIHaveStartedTheCalculator();
            PressButtons("1+1=");
        }

        [When(@"I press (.*)")]
        public void WhenIPress(string buttons)
        {
            PressButtons(buttons);
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
                    PressButtons(amount);                    
                }
            }

            PressEquals();
        }

        [When(@"I continue to add the following amounts")]
        public void WhenIContinueToAddTheFollowingAmounts(Table table)
        {
            foreach (var row in table.Rows)
            {
                Add(row.GetString("amount"));
            }

            PressEquals();
        }

        [When(@"I subtract (.*)")]
        public void WhenISubtract(string amount)
        {
            Subtract(amount);
            PressEquals();
        }

        [When(@"I multiply (.*) by (.*)")]
        public void WhenIMultiplyBy(string first, string second)
        {
            PressButtons(first);
            MultiplyBy(second);
            PressEquals();
        }

        [When(@"I divide (.*) by (.*)")]
        public void WhenIDivideBy(string first, string second)
        {
            PressButtons(first);
            DivideBy(second);
            PressEquals();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(string number)
        {
            Assert.AreEqual(number, NumberOnScreen());
        }

        private void Add(string amount)
        {
            PressButtons("+");
            PressButtons(amount);
        }

        private void Subtract(string amount)
        {
            PressButtons("-");
            PressButtons(amount);
        }

        private void MultiplyBy(string amount)
        {
            PressButtons("*");
            PressButtons(amount);
        }

        private void DivideBy(string amount)
        {
            PressButtons("/");
            PressButtons(amount);
        }

        private void PressEquals()
        {
            PressButtons("=");
        }

        private string NumberOnScreen()
        {
            var calculatorScreen = _calculatorWindow.Get<TextBox>("calculatorScreen");
            return calculatorScreen.Text;
        }

        private void PressButtons(string buttons)
        {
            foreach (char button in buttons)
            {
                PressButton(button);
            }
        }

        private void PressButton(char buttonText)
        {
            var button = _calculatorWindow.Get<Button>(SearchCriteria.ByText(buttonText.ToString()));
            button.Click();
        }
    }
}
