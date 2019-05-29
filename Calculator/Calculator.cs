namespace Calculator
{
    public class Calculator
    {
        internal int firstNum;
        internal int secondNum;
        internal int result;

        public virtual int Answer()
        {
            
        }
        
    }

    class Add : Calculator
    {
        public override int Answer()
        {
            System.Console.WriteLine("Sum is:");
            result = firstNum + secondNum;
            return result;
        }
    }

    class Subtract : Calculator
    {
        public override int Answer()
        {
            System.Console.WriteLine("Difference is:");
            result = firstNum - secondNum;
            return result;
        }
    }

    class Multiply : Calculator
    {
        public override int Answer()
        {
            System.Console.WriteLine("Sum is:");
            result = firstNum * secondNum;
            return result;
        }
    }

    class Divide : Calculator
    {
        public override int Answer()
        {
            System.Console.WriteLine("Sum is:");
            result = firstNum / secondNum;
            return result;
        }
    }


}
