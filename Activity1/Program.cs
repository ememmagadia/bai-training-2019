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
                int num1 = calc.ConvertNum(input1);

                Console.WriteLine("Enter second number:");
                string input2 = Console.ReadLine();
                int num2 = calc.ConvertNum(input2);

                Console.WriteLine("Enter operator: < + - * / >");
                calc.Sign = Console.ReadLine();
                
                try
                {
                    calc.operatorChecker(calc.Sign, num1, num2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not valid integer");
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
