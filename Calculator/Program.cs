using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations o = new Operations();

            Boolean Exit = false;
            while (!Exit)
            {

                o.Constant1 = GetInput("1st");
                o.Constant2 = GetInput("2nd");

                DetermineOperator(GetOperator(), o);

                Exit = ExitProgram();
            }
        }

        static int GetOperator()
        {
            Boolean Valid = false;
            while (!Valid)
            {
                Console.WriteLine("[1] Add, [2] Subtract, [3] Multiply, [4] Divide");
                Console.Write("Choose an operator: ");
                string input = Console.ReadLine();

                if (input.Length == 1 && Int32.TryParse(input, out int num))
                {
                    if (num > 0 && num < 5)
                    {
                        return num;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.\n");
                }
            }
            return 0;
        }

        static void DetermineOperator(int ans, Operations o)
        {
            if (ans == 1)
            {
                Console.WriteLine(o.Add());
            }
            else if (ans == 2)
            {
                Console.WriteLine(o.Subtract());
            }
            else if (ans == 3)
            {
                Console.WriteLine(o.Multiply());
            }
            else if (ans == 4)
            {
                Console.WriteLine(o.Divide());
            }
        }

        static int GetInput(string order)
        {
            Boolean Valid = false;
            while (!Valid)
            {
                Console.Write("Enter " + order + " number: ");
                string input1 = Console.ReadLine();

                if (Int32.TryParse(input1, out int num))
                {
                    Valid = true;
                    return num;
                }
                else
                {
                    Console.WriteLine("Input must be an integer.\n");
                }
            }
            return 0;
        }

        static Boolean ExitProgram()
        {
            Console.WriteLine("Type '0' and hit 'Enter' to exit the program. " +
                    "Enter anything else to continue.");
            Console.Write("Continue?: ");
            string  ans = Console.ReadLine();
            if (ans == "0")
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
