using System;

namespace VisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            char again = 'y';
            do
            {
                do
                {
                    Console.Write("Input Number:");

                    try
                    {
                        Num1 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please input a number!");
                    }

                    if (Num1 < 0) Console.WriteLine("Only positive numbers!");
                }
                while (Num1 < 0);



            }
            while (again == 'y' || again == 'Y');
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