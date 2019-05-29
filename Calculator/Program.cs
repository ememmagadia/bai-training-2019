using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = 0, SecondNum = 0;
            string position = "first";
            string again = "n";
            string answer = "0";
            do
            {
                FirstNum = getNum(answer, FirstNum, position);
                position = "second";
                SecondNum = getNum(answer, SecondNum, position);
                string operation = getOperation(answer);
                Calculate(FirstNum, SecondNum, operation);
                again = TryAgain();
                position = "first";
            }
            while (again == "y" || again == "Y");
        }

        private static string TryAgain()
        {
            string choice;
            do
            {
                Console.WriteLine("Do you want to try again? (Y/N): ");
                choice = Console.ReadLine();
            }
            while (!(choice == "y" || choice == "Y" || choice == "n" || choice == "N"));

            return choice;
        }

        private static void Calculate(int firstNum, int secondNum, string operation)
        {
            if (operation == "+")
            {
                Add add = new Add(firstNum, secondNum);
                Console.WriteLine(add.Calculate());
            }
            else if (operation == "-")
            {
                Subtract subt = new Subtract(firstNum, secondNum);
                Console.WriteLine(subt.Calculate());
            }
            else if (operation == "*")
            {
                Multiply mult = new Multiply(firstNum, secondNum);
                Console.WriteLine(mult.Calculate());
            }
            if (operation == "/")
            {
                Divide divide = new Divide(firstNum, secondNum);
                Console.WriteLine(divide.Calculate());
            }
        }

        private static string getOperation(string answer)
        {
            while (true)
            {
                Console.Write("Enter Operation + | - | * | / : ");
                answer = Console.ReadLine();

                if (answer == "+" || answer == "-" || answer == "*" || answer == "/")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input valid operation!");
                }
            }
            return answer;
        }
        private static int getNum(string answer, int Num, string position)
        {
            while (true)
            {
                Console.Write("Enter {0} number: ", position);
                answer = Console.ReadLine();
                if (!int.TryParse(answer, out Num))
                {
                    Console.WriteLine("Invalid! Please input number!");
                }
                else
                {
                    break;
                }
            }
            return Num;
        }
    }
}
