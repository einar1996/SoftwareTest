using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calc1 uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calc1();
        }

        [Test]
        public void AddTwoNumbers_1020_Equals30()
        {
            // Arrange in Setup

            // Act
           

            // Assert
            Assert.That(uut.Add(10, 20), Is.EqualTo(30));

        }

        [Test]
        public void SubtractTwoNumbers_1020_EqualsNeg10()
        {
            // Arrange in Setup

            // Act


            // Assert
            Assert.That(uut.Subtract(10, 20), Is.EqualTo(-10));

        }

        [Test]
        public void MultiplyTwoNumbers_1020_Equals200()
        {
            // Arrange in Setup

            // Act


            // Assert
            Assert.That(uut.Multiply(10, 20), Is.EqualTo(200));

        }
    }
}