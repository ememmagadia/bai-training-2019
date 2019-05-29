using System;
using TestLibrary;

namespace CalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = true;
            int Fnum = 0;
            int Snum = 0;

            while (test)
            {
                try
                {
                    Console.Write("Input first number:");
                    Fnum = Convert.ToInt32(Console.ReadLine());
                    test = false;

                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
            }
            test = true;
            while (test)
            {
                try
                {
                    Console.Write("Input second number:");
                    Snum = Convert.ToInt32(Console.ReadLine());
                    test = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                Console.Write("Input operation number:");


            }
            test = true;
            while (test)
            {
                TestClass.Operator = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                test = TestClass.calculate(Fnum, Snum);
            }



        }
    }
}
