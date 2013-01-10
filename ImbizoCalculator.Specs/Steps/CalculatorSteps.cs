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

        private void StartCalculator()
        {
            var application = Application.Launch("ImbizoCalculator.exe");
            _calculatorWindow = application.GetWindow("Calculator", InitializeOption.NoCache);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string number)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
