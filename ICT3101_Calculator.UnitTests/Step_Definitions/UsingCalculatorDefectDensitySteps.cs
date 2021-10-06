using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDefectDensitySteps
    {
        private double _result;

        private readonly Calculator calculators;
        public UsingCalculatorDefectDensitySteps(Calculator calculators) // use it as ctor parameter
        {
            this.calculators = calculators;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into calculator the and press Defect Density")]
        public void WhenIHaveEnteredAndIntoCalculatorTheAndPressDefectDensity(double p0, double p1)
        {
            _result = calculators.DefectDensity(p0, p1);
        }

        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSI(double p0, double p1, double p2)
        {
            _result = calculators.SSISecondRelease(p0, p1, p2);
        }

        [Then(@"the defect density result should be ""(.*)""")]
        public void ThenTheDefectDensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the defect density result should be positive infinity")]
        public void ThenTheDefectDensityResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }

        [Then(@"the SSI result for second release should be ""(.*)""")]
        public void ThenTheSSIResultForSecondReleaseShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
