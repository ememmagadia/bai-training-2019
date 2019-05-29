using System;

namespace Foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 fb = new Class1();
            int Num1 = 0;
            string answer;
            string again = "n";
            do
            {
                do
                {
                    Console.Write("Input Number:");
                    answer = Console.ReadLine();
                    if (int.TryParse(answer, out Num1))
                    {
                        if (Num1 < 0)
                        {
                            Console.WriteLine("Only Positive Numbers!");
                        }
                        else
                        {
                            Console.WriteLine(fb.Foobar(Num1));
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