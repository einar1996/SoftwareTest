﻿using System;
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


        [TestCase(45,10, 55)]
        [TestCase(-50, 10, -40)]
        [TestCase(1, 0.5, 1.5)]
        [Test]
        public void AddTwoNumbers_AB_EqualsResult(double a, double b, double result)
        {
            // Arrange in Setup

            // Act
            uut.Add(a, b);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(45, 10, 35)]
        [TestCase(-50, 10, -60)]
        [TestCase(0, 0.5, -0.5)]
        [Test]
        public void SubtractTwoNumbers_AB_EqualsNegResult(double a, double b, double result)
        {
            // Arrange in Setup
            
            // Act
            uut.Subtract(a, b);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(45, 10, 450)]
        [TestCase(-50, 10, -500)]
        [TestCase(0, 0.5, 0)]
        [Test]
        public void MultiplyTwoNumbers_AB_EqualsResult(double a, double b, double result)
        {
            // Arrange in Setup

            // Act
            uut.Multiply(a, b);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(45, 10, 4.5)]
        [TestCase(-50, 10, -5)]
        [TestCase(0, 0.5, 0)]
        [Test]
        public void DivideTwoNumbers_DividendDivisor_EqualsResult(double dividend, double divisor, double result)
        {
            // Arrange in Setup

            // Act
            uut.Divide(dividend, divisor);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(45, 10, 34050628916015625)]
        [TestCase(-50, 9, -1953125000000000)]
        [TestCase(0, 0.5, 0)]
        [Test]
        public void PowerTwoNumbers_XExponent_EqualsResult(double x, double exponent, double result)
        {
            // Arrange in Setup

            // Act
            uut.Power(x, exponent);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [Test]
        public void AddTwoNumbersAndClearAccumulator_1020_Equals0()
        {
            // Arrange in Setup

            // Act
            uut.Add(10, 20);
            uut.Clear();

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));

        }

        [TestCase(45, 10, 100)]
        [TestCase(-50, 10, -90)]
        [TestCase(0, 0.5, 0.5)]
        [Test]
        public void AddendAccumulator_AB_EqualsC(double a, double b, double result)
        {
            // Arrange in Setup
            uut.Add(a, b);
            // Act

            uut.Add(a);
            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        
        [TestCase(45, 10, -35)]
        [TestCase(-50, 10, 60)]
        [TestCase(0, 0.5, 0.5)]
        [Test]
        public void SubtractNumberFromAccumulator_NumberAccumulator_EqualsNegResult(double number, double accumulator, double result)
        {
            // Arrange in Setup
            uut.Add(accumulator);
            // Act
            uut.Subtract(number);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(45, 10, 450)]
        [TestCase(-50, 10, -500)]
        [TestCase(0, 0.5, 0)]
        [Test]
        public void MultiplyNumberToAccumulator_NumberAccumulator_EqualsResult(double number, double accumulator, double result)
        {
            // Arrange in Setup
            uut.Add(accumulator);
            // Act
            uut.Multiply(number);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(45, 10, 0.22)]
        [TestCase(10, -50, -5)]
        [TestCase(2, 2, 1)]
        [Test]
        public void DivideAccumulatorByNumber_AccumulatorDivisor_EqualsResult(double divisor, double accumulator, double result)
        {
            // Arrange in Setup
            uut.Add(accumulator);
            // Act
            uut.Divide(divisor);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(0.1));

        }

        [TestCase(2, 10, 100)]
        [TestCase(-3, 9, 0.00137)]
        [TestCase(0, 0.5, 1)]
        [Test]
        public void PowerAccumulator_AccumulatorExponent_EqualsResult(double exponent, double accumulator, double result)
        {
            // Arrange in Setup
            uut.Add(accumulator);
            // Act
            uut.Power(exponent);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(0.00001));

        }

        [TestCase(9, 3)]
        [TestCase(100, 10)]
        [TestCase(25, 5)]
        [Test]
        public void SQRTOfANumber_A_EqualsResult(double A, double result)
        {
            // Arrange in Setup
            
            // Act
            uut.SqaureRoot(A);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(0, 0)]
        [TestCase(9, 3)]
        [TestCase(36, 6)]
        [Test]
        public void SQRTOfAccumulator_Accumulator_EqualsResult(double accumulator, double result)
        {
            // Arrange in Setup
            uut.Add(accumulator);
            // Act
            uut.SqaureRoot();

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(0.00001));

        }

        [Test]
        public void DivideAccumulatorBy0_Accumulator0_ThrowsException()
        {
            // Arrange in Setup
            uut.Add(10);
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => uut.Divide(0), "Division with zero is impossible!");

        }
        [Test]
        public void DivideDividentByDivisor_DividentDivisor_ThrowsException()
        {
            // Arrange in Setup
            
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => uut.Divide(10,0), "Division with zero is impossible!");

        }

        [Test]
        public void SQRTOfAccumlatorLessThenZero_Accumulator_ThrowsException()
        {
            // Arrange in Setup
            uut.Add(-10);
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => uut.SqaureRoot(), "SQRT of less then zero is impossible!");

        }
        [Test]
        public void SQRTNumberLessThenZero_Number_ThrowsException()
        {
            // Arrange in Setup

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => uut.SqaureRoot(-25), "SQRT of less then zero is impossible!");

        }


    }
}