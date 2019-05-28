using Foobar;
using System;

namespace Foobar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 fb = new Class1();
            int Num1 = 0;
            string ans;
            string again = "n";
            do
            {
                do
                {
                    Console.Write("Input Number:");
                    ans = Console.ReadLine();
                    if (int.TryParse(ans, out Num1))
                    {
                        if (Num1 < 0)
                        {
                            Console.WriteLine("Only Positive Numbers!");
                        }
                        else
                        {
                            for (int i = 1; i <= Num1; i++)
                                Console.WriteLine(fb.Foobar(i));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please input a number!");
                    }
                }
                while (Num1 < 0);
                Console.WriteLine("Do you want to try again? (Y/y to try again)");
                again = Console.ReadLine();
            }
            while (again == "y" || again == "Y");
        }

    }
}

