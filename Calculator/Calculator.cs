using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    abstract class Calculator
    {
        protected int firstNum;
        protected int secondNum;
        protected int Result;

        public abstract int Calculate();
    }

    class Add : Calculator
    {
        public Add(int num1, int num2)
        {
            firstNum = num1;
            secondNum = num2;
        }

        public override int Calculate()
        {
            Console.Write("The total for " + firstNum + " and " + secondNum + " is ");
            return firstNum + secondNum;
        }
    }

    class Subtract : Calculator
    {
        public Subtract(int num1, int num2)
        {
            firstNum = num1;
            secondNum = num2;
        }

        public override int Calculate()
        {
            Console.Write("The difference between " + firstNum + " and " + secondNum + " is ");
            return secondNum - firstNum;
        }
    }

    class Divide : Calculator
    {
        public Divide(int num1, int num2)
        {
            firstNum = num1;
            secondNum = num2;
        }

        public override int Calculate()
        {
            Console.Write("The quotient of " + firstNum + " and " + secondNum + " is ");

            try
            {
                return firstNum / secondNum;
            }
            catch (DivideByZeroException e)
            {
                Console.Write("undefined because divisor is ");
                return 0;
            }
            
        }

    }

    class Multiply : Calculator
    {
        public Multiply(int num1, int num2)
        {
            firstNum = num1;
            secondNum = num2;
        }

        public override int Calculate()
        {
            Console.Write("The product of " + firstNum + " and " + secondNum + " is ");
            return firstNum * secondNum;
        }
    }

    class Remainder : Calculator
    {
        public Remainder(int num1, int num2)
        {
            firstNum = num1;
            secondNum = num2;
        }

        public override int Calculate()
        {
            Console.Write(" with a remainder of ");

            try
            {
                return firstNum % secondNum;
            }
            catch (DivideByZeroException e)
            {
                Console.Write("undefined because divisor is ");
                return 0;
            }
        }

    }
}
