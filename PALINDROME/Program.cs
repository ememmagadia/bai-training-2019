using System;
using System.Collections.Generic;
using System.Linq;

namespace PALINDROME
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListOfPalindrome = new List<string>(); // Palindrome list
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

            int length = ListOfPalindrome.Count();
            for (int i = 0; i < length; i++)
            {
                bool result = false;
                String original = ListOfPalindrome[i];
                String nospace = original.Replace(" ", "");
                String reverse = "";
                for (int j = nospace.Count() - 1; j >= 0; j--)
                {
                    reverse += nospace[j];
                }
                if (reverse.Equals(nospace))
                {
                    result = true;
                }
                Console.WriteLine("Word: " + original + " / Result: " + result);

            }
           
        }
    }
}
