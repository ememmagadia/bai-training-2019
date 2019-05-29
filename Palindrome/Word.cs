using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class Word
    {
        public String Palindrome(String word)
        {
            string original = word.Substring(0, word.Length / 2);
            char[] array = word.ToCharArray();

            Array.Reverse(array);

            string x = new String(array);
            string reverse = x.Substring(0, x.Length / 2);
            if (original.Equals(reverse))
            {
                word = "true";
            }
            else
            {
                word = "false";

            }

            return word;
        }
    }
}
