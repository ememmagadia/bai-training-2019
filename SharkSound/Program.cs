using System;
using System.Collections.Generic;
using System.Linq;

namespace SharkSound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListOfOperations = new List<string>();
            ListOfOperations.Add("+");
            ListOfOperations.Add("-");
            ListOfOperations.Add("*");
            ListOfOperations.Add("/");
            string op = "";
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
            while (true)
            {
                op = Console.ReadLine();
                if (ListOfOperations.Contains(op))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Try again and input a valid operation");
                }
                
            }
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
                    Console.WriteLine("The result is {0}", comp.Div(Num1, Num2));
                    break;
            }
        }
    }
}
