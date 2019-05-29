namespace Calculator
{
    abstract class Calculator
    {
        internal int firstNum;
        internal int secondNum;
        public abstract int Calculate();
    }

    class Add : Calculator
    {
        public Add (int num1, int num2)
        {
            firstNum = num1;
            secondNum = num2;
        }
        public override int Calculate()
        {
            System.Console.Write("The Sum {0} and {1} is: ", firstNum, secondNum);
            return firstNum+secondNum;
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
            System.Console.Write("The Difference of {0} and {1} is: ", firstNum, secondNum);
            return firstNum - secondNum;
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
            System.Console.Write("The Product of {0} and {1} is: ", firstNum, secondNum);
            return firstNum * secondNum;
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
            System.Console.Write("The Quotient of {0} and {1} is: ", firstNum, secondNum);
            return firstNum / secondNum;
        }
    }


}
