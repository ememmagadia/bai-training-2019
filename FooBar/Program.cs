using System;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        { 

            string loop = "N";
            int num;
            bool isNum;

            do
            {
                Console.Write("Enter any number: ");
                isNum = int.TryParse(Console.ReadLine(), out num);

                //Console.WriteLine("Accepted number is " + num);

                if(isNum)
                {
                    if (num > 0)
                    {
                        string output = GetOutput(num);
                        Console.WriteLine(output);
                    }
                    else
                    {
                        Console.WriteLine("I can only process positive numbers.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                

                //Console.Write("Try again? (Y/N): ");
                //loop = Console.ReadLine();

            } while (isNum);
        }

        static string GetOutput(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "Output: FooBar";
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
