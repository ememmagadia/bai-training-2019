using System;
using TestLibrary;

namespace VisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {

            TestClass foo = new TestClass();
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Input number:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(foo.FooBar(num));
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Input valid number");
                    }
                }
            }
           

        }
    }
}
