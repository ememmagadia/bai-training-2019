using System;
using System.Linq;

namespace Foobar
{
    class Program
    {
        public static void Main(string[] args)
        {
            string giveNum;
            int check = 0;
            bool containsText = false;
            bool containsNon = false;


            while (true)
            {
                try
                {
                    Console.Write("Please Enter the Number: ");
                    giveNum = Console.ReadLine();
                    containsText = giveNum.Any(c => char.IsLetter(c));
                    containsNon = giveNum.Contains("");
                    check = int.Parse(giveNum);
                }
                catch
                {
                    if (containsText)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    if (containsNon)
                    {
                        Console.WriteLine("Please Enter a Number!");
                    }

                }
                if (check % 3 == 0 && check % 5 == 0)
                {
                    Console.WriteLine("Foobar");
                }
                else if (check % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else if (check % 3 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (check < 0)
                {
                    Console.WriteLine("Positive Numbers Only");
                }
                else
                {
                    Console.WriteLine(check);
                }




            }



        }


    }
}
