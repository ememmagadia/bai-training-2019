using System;
using System.Linq;

namespace SharkSound
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            int Num2 = 0;
            Operations comp = new Operations();
            Console.Write("Input the first number:");
            while (true)
            {
                string Inp1 = Console.ReadLine();
                if (int.TryParse(Inp1,out Num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a number");
                }

            }   
            Console.Write("Input the second number:");
            while (true)
            {
                string Inp2 = Console.ReadLine();
                if (int.TryParse(Inp2, out Num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a number");
                }

            }

            Console.Write("Input the desired operation(+,-,*,/):");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine("The result is {0}", comp.Add(Num1, Num2));
                    break;
                case "-":
                    Console.WriteLine("The result is {0}", comp.Sub(Num1, Num2));
                    break;
                case "*":
                    Console.WriteLine("The result is {0}", comp.Mult(Num1, Num2));
                    break;
                case "/":
                    Console.WriteLine("The result is {0}", comp.Mult(Num1, Num2));
                    break;
                default:
                    Console.WriteLine("Try again and input a valid operation");
                    break;

            }
        }
    }
}
