using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace SpecFlowProject38.StepDefinitions
{
    [Binding]
    public class AdditionStepDefinitions
    {
        private readonly Calculator _calculator = new Calculator();

        private int _result;

        [Given(@"The first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            //throw new PendingStepException();
            _calculator.FirstNumber = p0;
        }

        [Given(@"The second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            //throw new PendingStepException();
            _calculator.SecondNumber = p0;
        }

        [When(@"The two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //throw new PendingStepException();
            _result = _calculator.Add();

        }

        [Then(@"The output should be (.*)")]
        public void ThenTheOutputShouldBe(int p0)
        {
            // throw new PendingStepException();
            _result.Should().Be(p0);
        }
    }
}
