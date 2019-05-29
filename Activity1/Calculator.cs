using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    class Calculator : Operators
    {
        private string sign;
        private double num1;
        private double num2;
        public string Sign
        {
            get { return sign; }
            set { sign = value; }
        }

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public double ConvertNum(string str)
        {
            double num = 0;
            bool isdouble = double.TryParse(str, out num);
            if (isdouble)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Invalid double");
                Environment.Exit(0);
                return 0;  
            }
        }

        public void operatorChecker(string sign, double num1, double num2)
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
