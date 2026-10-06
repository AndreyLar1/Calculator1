using System;

namespace Calculator
{
    public class Math
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => b != 0 ? a / b : 0;

        public long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++) result *= i;
        }
    }
}