using System;
using TestLibrary;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            TestClass foo = new TestClass();
            {
                    try
                    {
                        Console.Write("Input number:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for(int i = 1; num >= i; i++)
                        {
                            Console.WriteLine(foo.FooBar(i));
                        }

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
