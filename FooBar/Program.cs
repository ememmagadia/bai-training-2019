using System;

namespace FooBar
{
    class Program
    {

        static void Main(string[] args)
        {
            int num;
            bool isNum;
            bool isPosNum;

            do
            {
                Console.Write("Enter any number: ");
                //TryParse(string, save to)
                isNum = int.TryParse(Console.ReadLine(), out num);
                FooBarUtilities util = new FooBarUtilities();
                isNum = util.IsNum(isNum);
                if(isNum)
                {
                    isPosNum = util.IsPositiveNum(num);
                    if (isPosNum)
                    {
                        string output = util.GetOutput(num);
                        Console.WriteLine(output);
                    }
                }                

            } while (isNum);
        }

    }

    public class FooBarUtilities
    {
        public bool IsNum(bool isNum)
        {
            if (isNum)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Enter a valid number. Re-run to try again.");
                return false;
            }
        }

        public bool IsPositiveNum(int num)
        {
            if (num >= 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Enter a positive number.");
                return false;
            }
        }


        public string GetOutput(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FooBar";
            }

            else if (num % 5 == 0)
            {
                return "Bar";
            }

            else if (num % 3 == 0)
            {
                return "Foo";
            }

            else
            {
                return num.ToString();
            }
        }
    }
}
