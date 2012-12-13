using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
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

        [When(@"I press (.*)")]
        public void WhenIPress(string buttons)
        {
            ClickButtons(buttons);
        }

        [When(@"I add (.*) and (.*)")]
        public void WhenIAddAnd(string first, string second)
        {
            ClickButtons(first);
            ClickButtons("+");
            ClickButtons(second);
            ClickButtons("=");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string number)
        {
            Assert.AreEqual(number, NumberOnScreen());
        }

        private string NumberOnScreen()
        {
            var calculatorScreen = _calculatorWindow.Get<TextBox>("calculatorScreen");
            return calculatorScreen.Text;
        }

        private void ClickButtons(string digits)
        {
            foreach (char digit in digits)
            {
                ClickButton(digit);
            }
        }

        private void ClickButton(char digit)
        {
            var button = _calculatorWindow.Get<Button>(SearchCriteria.ByText(digit.ToString()));
            button.Click();
        }
    }
}
