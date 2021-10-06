using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    // Lab 4 Q10
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read(@"Your text file")).Returns(new string[4] { "3", "-1", "0", "1" });
            _calculator = new Calculator();
        }

        // Lab 4 Q4 If number of lines is 4 as .txt file contatins 3, -1, 0, 1
        [Test]
        public void MagicNumberMock_WithChoiceNegative_ResultIsZero()
        {
            // Act
            double result = _calculator.GenMagicNum(-1, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void MagicNumberMock_StringRetrievedIsPositiveNumber_ResultIsDoubleTheNumber()
        {
            // Act
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(-0));
        }

        [Test]
        public void MagicNumberMock_WithStringRetrievedIsNegativeNumber_ResultIsPositiveAndDoubleTheNumber()
        {
            // Act
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumberMock_WithStringRetrievedIsZero_ResultIsZero()
        {
            // Act
            double result = _calculator.GenMagicNum(2, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumberMock_WithChoiceNumberEqualsToNumberOfLines_ResultIsZero()
        {
            // Act
            double result = _calculator.GenMagicNum(4, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumberMock_WithChoiceMoreThanNumberOfLines_ResultIsZero()
        {
            // Act
            double result = _calculator.GenMagicNum(5, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
