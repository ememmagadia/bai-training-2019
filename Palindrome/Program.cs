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

            string a;

            for (int i = 0; i <= ListOfPalindrome.Count - 1; i++)
            {
                a = ListOfPalindrome[i];
                a = a.Replace(" ", String.Empty);

                Console.Write("Word: "); Console.Write(ListOfPalindrome[i]);
                Console.Write(" || "); Console.Write("Result: ");
                Console.WriteLine(IsPalindrome(a));
            }
        }

        static Boolean IsPalindrome(string input)
        {
            int MatchCtr = 0;

            char[] arr = input.ToCharArray();
            int Len = arr.Length;
            int LenHalf = Len / 2;
            int LenCtr = LenHalf - 1;

            for (int i = 0; i <= LenCtr; i++)
            {
                if (arr[i] == arr[Len - 1 - i])
                {
                    MatchCtr++;
                }
            }

            if (MatchCtr == LenHalf)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
