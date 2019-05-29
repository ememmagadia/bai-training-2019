using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    class Operators
    {
        public void Result(int ans)
        {
            Console.WriteLine("Result: {0} \n", ans);
        }
        public void Add(int num1, int num2)
        {
            Result(num1 + num2);
        }

        public void Subtract(int num1, int num2)
        {
            Result(num1 - num2);
        }

        public void Divide(int num1, int num2)
        {
            Result(num1 / num2);
        }

        public void Multiply(int num1, int num2)
        {
            Result(num1 * num2);
        }
    }
}
