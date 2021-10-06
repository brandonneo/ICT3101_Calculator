using System;
using TechTalk.SpecFlow;
using NUnit.Framework;



namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Calculator _calculator;
        private double _result;
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
