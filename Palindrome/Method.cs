using System;

namespace Palindrome
{
    public static class Method
    {
        public static void DisplayPalindrome(string disp)
        {
            bool isPalindrome = true;
            string str = RemoveSpace(disp);
            isPalindrome = PalindromeCheck(str, isPalindrome);
            Console.WriteLine("{0}: / Result is: {1}", disp, isPalindrome);
        }

        private static bool PalindromeCheck(string disp, bool isPalindrome)
        {
            for (int i = 0; i <= disp.Length / 2; i++)
            {
                if (disp[i] == disp[disp.Length - (i + 1)])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                    return isPalindrome;
                }
            }
            return isPalindrome;
        }

        private static string RemoveSpace(string disp)
        {
            disp = disp.Replace(" ", "");
            return disp;
        }
    }
}
