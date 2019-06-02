using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class isPalindrome
    {
        public static bool CheckPalindrome(string palindrome)
        {

            int i = 0;
            int j = palindrome.Length - 1;


            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char check1 = palindrome[i];
                char check2 = palindrome[j];

                if (palindrome[i] == palindrome[j] - i - 1)
                {
                    if (palindrome[i] != palindrome[j])
                    {
                        return false;
                    }

                }
                i++;
                j--;

            }

        }
    }
}

    