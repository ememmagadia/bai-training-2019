using System;
using FooBar;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR");

            FooBarClass p = new FooBarClass();
            while (true)
            {
                Console.WriteLine("Enter a number:");
                string str = Console.ReadLine();      
                int num  =  p.ConvertNum(str);

                try
                {
                    bool b = p.IsNotNegative(num);
                    if (b)
                    {
                        p.CheckInput(num);
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