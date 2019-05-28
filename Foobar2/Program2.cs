using System;
using Foobar;
namespace Foobar
{
    class Program
    {
        static void Main()
        {
            Class1 n = new Class1();
            Console.WriteLine("Type exit to stop");
            Console.WriteLine("Please input a positive number");
            while (true)
            {
                string read = Console.ReadLine();
                if (string.Equals(read, "exit"))
                {
                    break;
                }
                if (int.TryParse(read, out int Ans))
                {
                    if (Ans > 0)
                    {
                        for (int i = 1; i<= Ans; i++)
                        {
                            n.Number(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input a positive number");
                    }
                }
                else
                {
                    Console.WriteLine("Please input a whole number");
                }
            }
        }
    }
}
