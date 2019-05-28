using System;

namespace Foobar
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        if (Num1<0)
                        {
                            Console.WriteLine("Only Positive Numbers!");
                        }
                        else
                        {
                            Console.WriteLine(Foobar(Num1));
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

        public static string Foobar(int a)
        {
            string disp = "";
            if (a % 3 == 0 && a % 5 == 0)
            {
                disp = "Foobar";
            }
            else if (a % 5 == 0)
            {
                disp = "Bar";
            }
            else if (a % 3 == 0)
            {
                disp = "Foo";
            }
            else
            {
                return a.ToString();
            }

            return disp;

        }
    }

}