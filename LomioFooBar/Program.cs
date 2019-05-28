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
            int x = 0;
            Class1 num = new Class1();
            Console.WriteLine("Type exit to esc");
            while (x <= 10)
            {
                Console.WriteLine("Enter a number");
                string Input = Console.ReadLine();
                if (Input.Equals("exit"))
                {
                    System.Environment.Exit(1);
                }
               else if (int.TryParse(Input, out Number))
                {
                    ValidNumber = true;
                    Number = Int32.Parse(Input);

                    for (int i = 1; i <= Number; i++)
                    {
                        //calling the Number method
                        num.Number(i);
                    }
                    x++;
                }

                else
                {
                    Console.WriteLine("Please input  number");
                }
            }

            Console.WriteLine("Press ESC to exit");
            Console.ReadKey();

        }
    }
}
