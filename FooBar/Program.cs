using System;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] msg = { "FOO", "BAR", "FOOBAR" };

            while (true)
            {
                Console.WriteLine("Enter a number: <Press Q to exist>");
                string str = Console.ReadLine();

                try
                {
                    int num = Convert.ToInt32(str);
                    if (num > 0)
                    {
                        if (num % 3 == 0)
                        {
                            Console.WriteLine(msg[0]);
                        }
                        else if (num % 5 == 0)
                        {
                            Console.WriteLine(msg[1]);
                        }
                        else if (num % 3 == 0 && num % 5 == 0)
                        {
                            Console.WriteLine(msg[2]);
                        }
                        else if (num % 3 != 0 || num % 5 != 0)
                        {
                            Console.WriteLine(num);
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No negative");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not valid integer");
                }

                if (str.ToLower() == "q")
                {
                    break;
                }
            }
        }
    }
}