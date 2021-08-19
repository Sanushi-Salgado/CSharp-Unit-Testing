using System;

namespace EssentialTraining
{
    public class MathFunctions
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
                throw new ArithmeticException("Division by zero!");
            else
                return num1 / num2;
        }

    }
}
