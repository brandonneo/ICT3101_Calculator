using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {

        private double _result;

        private readonly Calculator calculators;
        public UsingCalculatorAvailabilitySteps(Calculator calculators) // use it as ctor parameter
        {
            this.calculators = calculators;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into calculator the and press MTBF")]
        public void WhenIHaveEnteredAndIntoCalculatorTheAndPressMTBF(double p0, double p1)
        {
            _result = calculators.MTBF(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = calculators.Availability(p0, p1);
        }

        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be positive infinity")]
        public void ThenTheAvailabilityResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
    }
}
