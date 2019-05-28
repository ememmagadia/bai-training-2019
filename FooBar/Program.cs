using System;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        { 

            int num;
            bool isNum;

            do
            {
                Console.Write("Enter any number: ");
                //TryParse(string, save to)
                isNum = int.TryParse(Console.ReadLine(), out num);

                if(isNum)
                {
                    if (num >= 0)
                    {
                        string output = GetOutput(num);
                        Console.WriteLine(output);
                    }
                    else
                    {
                        Console.WriteLine("Enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number. Re-run to try again.");
                }

            } while (isNum);
        }

        static string GetOutput(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "Output:FooBar";
            }

            else if (num % 5 == 0)
            {
                return "Output: Bar";
            }

            else if (num % 3 == 0)
            {
                return "Output: Foo";
            }

            else
            {
                return "Output: " + num;
            }
        }
    }
}
