using System;
using FooBar;

namespace FooBar2
{
    class Program2
    {
        static void Main(string[] args)
        {
            FooBarClass p = new FooBarClass();
            while (true)
            {
                Console.WriteLine("Enter a number:");
                string str = Console.ReadLine();
                int num = p.ConvertNum(str);

                try
                {
                    bool b = p.IsNotNegative(num);
                    if (b)
                    {
                        for (int i = 1; i < num + 1; i++)
                        {
                            p.CheckInput(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Does not accept negative values");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not valid integer");
                }

            }

        }
    }
}
