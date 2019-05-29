using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Palindrome
    {
        public void CheckForPalindrome(string s){
            if(s.Length == 1)
            {
                Console.WriteLine("Word: {0} / Result: True", s);
            }
            else
            {
                char[] word = s.ToCharArray();
                int len = word.Length;
                bool isPalindrome = false;
                for(int i = 0; i < len; i++)
                {
                    if (word[i] == word[len - 1 - i])
                    {
                        isPalindrome = true;
                    }
                    else isPalindrome = false;
                }

                Console.WriteLine("Word: {0} / Result: {1}", s, isPalindrome);
            }
            
        }
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();

            List<string> ListOfPalindrome = new List<string>
            {
                "civic",
                "deified",
                "deleveled",
                "devoved",
                "dewed",
                "Hannah",
                "kayak",
                "level",
                "madam",
                "racecar",
                "radar",
                "redder",
                "refer",
                "repaper",
                "reviver",
                "rotator",
                "rotor",
                "sagas",
                "solos",
                "sexes",
                "stats",
                "tenet",
                "Dot",
                "A",
                "Palindrome",
                "Race caR",
                "RaCe CaR",
                "rAce caR"
            }; // Palindrome list

            foreach (string s in ListOfPalindrome)
            {
                p.CheckForPalindrome(s);
            }
        }
    }
}
