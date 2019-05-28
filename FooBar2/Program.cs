using System;
using FooBar;

namespace FooBar2
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            bool isNum;
            bool isPosNum;

            FooBarUtilities util = new FooBarUtilities();

            do
            {
                Console.Write("Enter any number: ");
                //TryParse(string, save to)
                isNum = int.TryParse(Console.ReadLine(), out limit);
                isNum = util.IsNum(isNum);

                for (int start=1; start<=limit; start++)
                {
                    isPosNum = util.IsPositiveNum(start);
                    if (isPosNum)
                    {
                        string output = util.GetOutput(start);
                        Console.WriteLine(output);
                    }
                }
            } while (isNum);
        }
    }
}
