using System;
using System.Linq;

namespace Foobar2
{
    class Program
    {
        static void Main(string[] args)
        {

            string giveNum;
            int check = 0;
            bool containsText = false;
            bool containsNon = false;


            while (true)
            {
                Console.Write("Enter A Number: ");
                try
                {

                    giveNum = Console.ReadLine();
                    containsText = giveNum.Any(c => char.IsLetter(c));
                    containsNon = giveNum.Contains("");
                    check = int.Parse(giveNum);
                    if (int.TryParse(giveNum, out check))
                    {
                        if (containsNon)
                        {
                            Console.WriteLine("Enter a Number!");
                        }
                    }

                }
                catch
                {

                }
                if (containsText)
                {
                    Console.WriteLine("Invalid Input");
                }
                for (int i = check; i > 0; i--)
                {
                    
                    if (i.Equals(null))
                    {
                        Console.WriteLine("Enter a Number!");
                    }

                    else if (i < 0)
                    {
                        Console.WriteLine("Positive Numbers Only");
                    }

                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Foobar");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Bar");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Foo");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }


            }
        }
    }
}

