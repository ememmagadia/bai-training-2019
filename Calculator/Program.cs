using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsValid;
            int FirstNum;
            int SecondNum;

            do
            {
                // Check if valid number
                Console.Write("Enter the first number: ");
                IsValid = int.TryParse(Console.ReadLine(), out FirstNum);
                CheckNumber(IsValid);

                Console.Write("Enter the second number: ");
                IsValid = int.TryParse(Console.ReadLine(), out SecondNum);
                CheckNumber(IsValid);

                // Check if valid operator
                Console.Write("Enter an operator( + | - | * | / ): ");
                string CalcOperator = Console.ReadLine().Trim();
                IsValid = CheckOperator(CalcOperator);

                if (IsValid)
                {
                    CallOperation(CalcOperator, FirstNum, SecondNum);
                }

            } while (IsValid);
            
        }

        static void CheckNumber(bool IsValid)
        {
            if (!IsValid)
            {
                Console.WriteLine("Please enter a valid number");
                Environment.Exit(0);
            }
        }

        static bool CheckOperator(string Optr)
        {
            if (Optr == "+" || Optr == "-" || Optr == "*" || Optr == "/")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid operator.");
                Environment.Exit(0);
                return false;
            }
        }

        static void CallOperation(string Optr, int FirstNum, int SecondNum)
        {
            int Result;
            if (Optr == "+")
            {
                Add add = new Add(FirstNum, SecondNum);
                Result = add.Calculate();
                Console.WriteLine(Result);
            }
            else if (Optr == "-")
            {
                Subtract sub = new Subtract(FirstNum, SecondNum);
                Result = sub.Calculate();
                Console.WriteLine(Result);
            }
            else if (Optr == "/")
            {
                Divide div = new Divide(FirstNum, SecondNum);
                Remainder mod = new Remainder(FirstNum, SecondNum);
                Result = div.Calculate();
                Console.Write(Result);
                Result = mod.Calculate();
                Console.WriteLine(Result);
            }
            else if (Optr == "*")
            {
                Multiply mul = new Multiply(FirstNum, SecondNum);
                Result = mul.Calculate();
                Console.WriteLine(Result);
            }
        }
    }
}
