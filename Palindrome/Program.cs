using System;
using System.Collections.Generic;

namespace Palindrome
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
            for (int i = 0; i < ListOfPalindrome.Count; i++)
            {
                String removeWhiteSpace = ListOfPalindrome[i].Replace(" ", String.Empty);

                var word = new Word.B();
                String result = word.GetValue(removeWhiteSpace);
                Console.WriteLine("Word {0} Result {1}" , ListOfPalindrome[i],result);
            }



        }
    }
}
