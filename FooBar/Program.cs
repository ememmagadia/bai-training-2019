using System;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            while (true)
            {
                Console.WriteLine("Enter a number:");
                string str = Console.ReadLine();

                p.ConvertToInt(str);

                Console.WriteLine("< -- Press ESC to exit -- >");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        public void ConvertToInt(string str)
        {
            Program p = new Program();
            try
            {
                int num = Convert.ToInt32(str);

                if (num > 0)
                {
                    p.CheckInput(num);
                }
                else
                {
                    Console.WriteLine("Does not accept negative values");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid integer");
            }
        }
        public void CheckInput(int num)
        {
            string[] msg = { "FOO", "BAR", "FOOBAR" };
            if (num % 3 == 0)
            {
                Console.WriteLine(msg[0]);
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine(msg[1]);
            }
            else if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine(msg[2]);
            }
            else if (num % 3 != 0 || num % 5 != 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}