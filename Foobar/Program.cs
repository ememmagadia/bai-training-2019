using System;

namespace Foobar
{
    class Program
    {
        public String Number(String Num1)
        {
            bool ValidNumber = false;
            int Number;
            if (int.TryParse(Num1, out Number))
            {
                ValidNumber = true;
                Number = Int32.Parse(Num1);
                if (Number == 0)
                {
                    Console.WriteLine("FOOBAR");
                    Console.ReadKey();
                }
                else if (Number < 0)
                {
                    Console.WriteLine("Please Greater Than zero");
                    Console.ReadKey();
                }
                else if (Number % 15 == 0)
                {
                    Console.WriteLine("FOOBAR");
                    Console.ReadKey();
                }
                else if (Number % 3 == 0)
                {
                    Console.WriteLine("FOO");
                    Console.ReadKey();

                }
                else if (Number % 5 == 0)
                {
                    Console.WriteLine("BAR");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine(Num1);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Please input  number");
                Console.ReadKey();
            }
            return Num1;
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            int i = 0;
            while (i <= 3)
             {
            Console.WriteLine("Enter a number");
                string Input = Console.ReadLine();
                //calling the Number method
                n.Number(Input);
                i++;
               }

        }
    }
}
