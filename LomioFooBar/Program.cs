using Foobar;
using System;
namespace LomioFooBar
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ValidNumber = false;
            int Number;

            Class1 num = new Class1();
          
                Console.WriteLine("Enter a number");
                string Input = Console.ReadLine();
                if (int.TryParse(Input, out Number))
                {
                    ValidNumber = true;
                    Number = Int32.Parse(Input);
                for (int i = 1; i <= Number; i++)
                {
                    //calling the Number method
                    num.Number(i);
                }
                }
                else
                {
                    Console.WriteLine("Please input  number");
                }

            Console.WriteLine("Press ESC to exit");
            Console.ReadKey();

        }
    }
}
