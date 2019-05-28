using System;
using FooBar;

namespace FooBarExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int number;

            Console.WriteLine("FOO BAR EXTENDED");
            Console.WriteLine("Number will be enumerated from 1 to the given input. Numbers less than 1 will be ignored.");
            Console.WriteLine("If the number is divisible by 3, the output will be FOO.");
            Console.WriteLine("If the number is divisible by 5, the output will be BAR.");
            Console.WriteLine("If the number is divisible by 3 AND 5, the output will be FOOBAR.");
            Console.WriteLine("If the number is neither divisible by 3 OR 5, the output will be the number entered.");
            Console.WriteLine("To exit the program, type x and press enter.");


            while (input != "x")
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
                if (input == "x")
                {
                    Console.WriteLine("Exiting program!");
                }
                else
                {
                    if (int.TryParse(input, out number))
                    {
                        FooBarProgram f = new FooBarProgram();
                        int ctr = 1;
                        while (ctr <= number)
                        {
                            Console.WriteLine(f.IsFoobar(ctr));
                            ctr++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number. \n");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
