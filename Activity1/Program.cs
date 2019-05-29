using System;

namespace Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CALCULATOR =====");
            Console.WriteLine("");

            Calculator calc = new Calculator();
            while (true)
            {

                Console.WriteLine("Enter first number:");
                string input1 = Console.ReadLine();
                double num1 = calc.ConvertNum(input1);

                if (num1 == 0)
                {
                    continue;
                }

                Console.WriteLine("Enter second number:");
                string input2 = Console.ReadLine();
                double num2 = calc.ConvertNum(input2);

                if (num2 == 0)
                {
                    continue;
                }

                Console.WriteLine("Enter operator: < + - * / >");
                calc.Sign = Console.ReadLine();
                
                try
                {
                    bool check = calc.operatorChecker(calc.Sign, num1, num2);
                    if (check)
                    {
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not valid double");
                    continue;
                }

                Console.WriteLine("Do you want to exit? (Y/N)");
                string ques = Console.ReadLine();

                if (ques.ToUpper() == "Y")
                {
                    break;
                }
            }
        }
    }
}
