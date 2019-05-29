using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    class Operators
    {
        public void Result(double ans)
        {
            Console.WriteLine("Result: {0} \n", ans);
        }
        public void Add(double num1, double num2)
        {
            Result(num1 + num2);
        }
        public void Subtract(double num1, double num2)
        {
            Result(num1 - num2);
        }

        public void Divide(double num1, double num2)
        {
            Result(num1 / num2);
        }

        public void Multiply(double num1, double num2)
        {
            Result(num1 * num2);
        }
    }
}
