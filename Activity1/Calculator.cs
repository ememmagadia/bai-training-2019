using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    class Calculator : Operators
    {
        private string sign;
        private int num1;
        private int num2;
        public string Sign
        {
            get { return sign; }
            set { sign = value; }
        }

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public int ConvertNum(string str)
        {
            int num = 0;
            bool isInt = int.TryParse(str, out num);
            if (isInt)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Invalid Integer");
                Environment.Exit(0);
                return 0;  
            }
        }

        public void operatorChecker(string sign, int num1, int num2)
        {
            if (sign == "+")
            {
                Add(num1, num2);
            }
            else if (sign == "-")
            {
                Subtract(num1, num2);
            }
            else if (sign == "*")
            {
                Multiply(num1, num2);
            }
            else if (sign == "/")
            {
                Divide(num1, num2);
            }
            else
            {
                Console.WriteLine("You entered invalid operator. Only accept: + | - | * | / ");
                Environment.Exit(0);
            }
        }



    }
}
