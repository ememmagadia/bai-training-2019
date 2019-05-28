using System;
using System.Linq;

namespace Foobar
{
    class Program
    {
        public static void Main(string[] args)
        {

            string giveNum;
            int check =0 ;
            bool containsText = false;
            bool containsNon = false;


            while (true)
            {
                try
                {
                    Console.Write("Enter A Number: ");
                    giveNum = Console.ReadLine();
                    containsText = giveNum.Any(c => char.IsLetter(c));
                    containsNon = giveNum.Contains("");
                    check = int.Parse(giveNum);
                    if (int.TryParse(giveNum,out check))
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
                else if (check.Equals(null))
                {
                    Console.WriteLine("Enter a Number!");
                }

                else if (check < 0)
                {
                    Console.WriteLine("Positive Numbers Only");
                }

                else if (check % 3 == 0 && check % 5 == 0)
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
                else
                {
                    Console.WriteLine(check);
                }

            }
        }

    }
}
