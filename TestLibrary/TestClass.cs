using System;

namespace TestLibrary
{
    public class TestClass
    {
        public string FooBar(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "Foobar";
            }
            if (num % 3 == 0)
            {
                return "Foo";
            }
            if (num % 5 == 0)
            {
                return "Bar";
            }
            else
            {
                return num.ToString();
            }
        }

        public static char Operator { get; set; }

        public static bool calculate(int num1,int num2)
        {
            Calculator calc = new Calculator(num1, num2);
            bool result;
            switch (TestClass.Operator)
            {
                case '+':
                    calc.Add();
                    result = false;
                    break;
                case '-':
                    calc.Subtract();
                    result = false;
                    break;
                case '*':
                    calc.Multiply();
                    result = false;
                    break;
                case '/':
                    calc.Divide();
                    result = false;
                    break;
                default:
                    Console.Write("input valid operator:");
                    result = true;
                    break;
            }
            return result;

        }
        public bool IsPalindrome(string input)
        {
            int len = input.Length;
            char[] arrayInput = input.ToCharArray();
            string revString = "";
            for(int i = len-1;i >=0;i--)
            {
                revString += arrayInput[i];
            }

            if (input.Equals(revString))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
