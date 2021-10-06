﻿using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private double _result;

        private readonly Calculator calculators;
        public UsingCalculatorBasicReliabilitySteps(Calculator calculators) // use it as ctor parameter
        {
            this.calculators = calculators;
        }
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFailureIntensity(double p0, double p1, double p2)
        {
            _result = calculators.CurrentFailureIntensity(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressExpectedFailures(double p0, double p1, double p2)
        {
            _result = calculators.AverageNumberofExpectedFailures(p0, p1, p2);
        }
        
        [Then(@"the failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the failure intensity result should be negative infinity")]
        public void ThenTheFailureIntensityResultShouldBeNegativeInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.NegativeInfinity));
        }

        [Then(@"the number of expected failures result should be ""(.*)""")]
        public void ThenTheNumberOfExpectedFailuresResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
