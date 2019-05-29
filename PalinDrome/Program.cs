using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PalinDrome
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<string> ListOfPalindrome = new List<string>();

            PalinDromeClass p = new PalinDromeClass();

            ListOfPalindrome.Add("civic");
            ListOfPalindrome.Add("deified");
            ListOfPalindrome.Add("deleveled");
            ListOfPalindrome.Add("devoved");
            ListOfPalindrome.Add("dewed");
            ListOfPalindrome.Add("Hannah");
            ListOfPalindrome.Add("kayak");
            ListOfPalindrome.Add("level");
            ListOfPalindrome.Add("madam");
            ListOfPalindrome.Add("racecar");
            ListOfPalindrome.Add("radar");
            ListOfPalindrome.Add("redder");
            ListOfPalindrome.Add("refer");
            ListOfPalindrome.Add("repaper");
            ListOfPalindrome.Add("reviver");
            ListOfPalindrome.Add("rotator");
            ListOfPalindrome.Add("rotor");
            ListOfPalindrome.Add("sagas");
            ListOfPalindrome.Add("solos");
            ListOfPalindrome.Add("sexes");
            ListOfPalindrome.Add("stats");
            ListOfPalindrome.Add("tenet");
            ListOfPalindrome.Add("Dot");
            ListOfPalindrome.Add("A");
            ListOfPalindrome.Add("Palindrome");
            ListOfPalindrome.Add("Race caR");
            ListOfPalindrome.Add("RaCe CaR");
            ListOfPalindrome.Add("rAce caR");

            for (int c = 0; c < ListOfPalindrome.Count; c++)
            {
                string reverse="";
                string proper = ListOfPalindrome[c];
                int length = proper.Length;

                while (length > 0)
                {
                    reverse += proper[length-1];
                    length--;
                }

                proper = Regex.Replace(ListOfPalindrome[c], @"\s", "");
                reverse = Regex.Replace(reverse, @"\s", "");

                bool result = p.IsMatch(proper, reverse);

                Console.WriteLine("Word: {0} - {1} Result: {2}", proper, reverse, result);
            }

        }

    }
}
