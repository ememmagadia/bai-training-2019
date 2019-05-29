using System;
using TestLibrary;

namespace CalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //TestClass calculator = new TestClass();
                bool test = true;
                Console.Write("Input first number:");
                int Fnum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input second number:");
                int Snum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input operation number:");
                while (test)
                {
                    TestClass.Operator = Console.ReadKey().KeyChar;
                    Console.WriteLine("");
                    test = TestClass.calculate(Fnum, Snum);
                }
            }

        }
    }
}
