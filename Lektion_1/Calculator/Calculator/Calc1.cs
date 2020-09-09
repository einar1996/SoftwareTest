﻿using System;

namespace Calculator
{
    public class Calc1
    {
        public double Accumulator { get; private set; }
        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }
        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }
        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }
        public double Power(double x, double exp)
        {
            return Accumulator = Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Division with zero is impossible!");
            }

            return Accumulator = dividend / divisor;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double addend)
        {
            return Accumulator += addend;
        }
        public double Subtract(double subtractor)
        {
            return Accumulator -= subtractor;
        }
        public double Multiply(double multiplier)
        {
            return Accumulator *= multiplier;
        }
        public double Power(double exponent)
        {
            return Accumulator = Math.Pow(Accumulator, exponent);
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Division with zero is impossible!");
            }

            return Accumulator /= divisor;
        }

        public double SqaureRoot(double SQRTNR)
        {
            if (SQRTNR < 0)
            {
                throw new ArgumentException("SQRT of less then zero is impossible!");
            }
            return Accumulator= Math.Sqrt(SQRTNR);
        }

        public double SqaureRoot()
        {
            if (Accumulator < 0)
            {
                throw new ArgumentException("SQRT of less then zero is impossible!");
            }
            return Accumulator = Math.Sqrt(Accumulator);
        }
    }
}