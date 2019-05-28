using System;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int number;

            Console.WriteLine("FOO BAR");
            Console.WriteLine("If the number is divisible by 3, the output will be FOO.");
            Console.WriteLine("If the number is divisible by 5, the output will be BAR.");
            Console.WriteLine("If the number is divisible by 3 AND 5, the output will be FOOBAR.");
            Console.WriteLine("If the number is neither divisible by 3 OR 5, the output will be the number entered.");
            Console.WriteLine("To exit the program, type x and press enter.");
            

            while(input != "x")
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
                if (input == "x")
                {
                    Console.WriteLine("Exiting program!");
                }
                else
                {
                    if(int.TryParse(input, out number))
                    {
                        if(number == 0)
                        {
                            Console.WriteLine(number);
                        }
                        else if(number % 3 == 0 && number % 5 == 0)
                        {
                            Console.WriteLine("FOOBAR");
                        }
                        else if(number % 3 == 0 && number % 5 != 0)
                        {
                            Console.WriteLine("FOO");
                        }
                        else if (number % 3 != 0 && number % 5 == 0)
                        {
                            Console.WriteLine("BAR");
                        }
                        else
                        {
                            Console.WriteLine(number);
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
