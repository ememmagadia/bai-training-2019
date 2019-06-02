using System;
using System.Collections.Generic;


namespace Palindrome
{
    class Program
    {

        public static void Main(string[] args)
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
            ListOfPalindrome.Add("a man a palan a canal panama");
            ListOfPalindrome.Add("A man a palan a canal panama");

            foreach (string palindrome in ListOfPalindrome)
            {

                Console.WriteLine("Work: {0} / Result : {1}", palindrome, CheckPalindrome(palindrome));
            }

        }
        public static bool CheckPalindrome(string palindrome)
        {
            int palLength = palindrome.Length;

            while (true)
            {
                for (int i = 0; i <= palLength / 2; i++)
                {

                    if (palindrome[i] != palindrome[palLength - i - 1])
                    {

                        return false;

                    }
                    
                    return true;

                   
                }


            }



        }
    }
}







