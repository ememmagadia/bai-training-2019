using System;

namespace Foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 n = new Class1();
            int i = 0;
            while (i <= 3)
            {
                Console.WriteLine("Enter a number");
                string Input = Console.ReadLine();
                //calling the Number method
                n.Number(Input);
                i++;
            }
            Console.WriteLine("Press ESC to exit");
            Console.ReadKey();

        }
    }
}
