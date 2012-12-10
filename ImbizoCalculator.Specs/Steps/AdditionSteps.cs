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
            Application application = Application.Launch("ImbizoCalculator.exe");
            _calculatorWindow = application.GetWindow("Calculator", InitializeOption.NoCache);
        }

        [When(@"I press (.*)")]
        public void WhenIPress(string digits)
        {
            foreach (char digit in digits)
            {
                var button = _calculatorWindow.Get<Button>(SearchCriteria.ByText(digit.ToString()));
                button.Click();
            }
        }

        [When(@"I add (.*) and (.*)")]
        public void WhenIAddAnd(string first, string second)
        {
            WhenIPress(first);
            WhenIPress("+");
            WhenIPress(second);
            WhenIPress("=");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string number)
        {
            var calculatorScreen = _calculatorWindow.Get<TextBox>("calculatorScreen");
            Assert.AreEqual(number, calculatorScreen.Text);
        }
    }
}
