using System;
namespace FOOBAR
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool repeat = true;
            while (repeat)
            {

                int number = 0;
                object type;
                bool integer = false;

                while (!integer)
                {
                    Console.WriteLine("Please Input number");
                    String b = Console.ReadLine();
                    try
                    {
                        number = Int32.Parse(b);

                        integer = true;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not an integer");

                    }
                    if (number < 0)
                    {
                        Console.WriteLine("number should not be less than 0");
                        integer = false;
                    }

                }

                if (number % 3 == 0 && number % 5 == 0)
                {
                    type = "FOOBAR";
                }
                else if (number % 3 == 0)
                {
                    type = "FOO";
                }
                else if (number % 5 == 0)
                {
                    type = "BAR";
                }
                else
                {
                    type = number;
                }

                Console.WriteLine("Your input: " + number + " Value: " + type);
                Console.WriteLine("Again? (Y/N)");
                String c;
                c = Console.ReadLine();
                if (c == "N")
                {
                    repeat = false;
                }
                else if (c == "Y")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value, Program Terminated");
                    repeat = false;
                }
            }
        }
    }
}
