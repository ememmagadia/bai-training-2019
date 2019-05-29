using System;
using System.Collections.Generic;
using System.Text;

namespace PalinDrome
{
    class PalinDromeClass
    {

        public bool IsMatch(string a, string b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void PrintList(List<string> listOfPalindrome)
        {
            for (int c = 0; c < listOfPalindrome.Count; c++)
            {
                string reverse = "";
                string proper = listOfPalindrome[c];
                int length = proper.Length;

                while (length > 0)
                {
                    reverse += proper[length - 1];
                    length--;
                }

                proper = listOfPalindrome[c].Replace(" ", "");
                reverse = reverse.Replace(" ", "");

                bool result = IsMatch(proper, reverse);

                Console.WriteLine("Word: {0} / Result: {1}", proper, result);
            }
        }
    }
}
