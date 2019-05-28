using System;
using Foobar;

namespace Foobar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Input = new Class1();
            Class2 Output = new Class2();

            String input = "";

            Output.StartMsg();

            while (input != "exit")
            {
                Output.InputMsg();

                input = Console.ReadLine();

                if (Int32.TryParse(input, out int num) && input != "exit" && num > 0)
                {
                    for(int i = 1; i <= num; i++)
                    {
                        Input.DetermineFoobar(i);
                    }
                }
                else
                {
                    Output.ErrorMsg();
                }
            }
        }
    }
}
