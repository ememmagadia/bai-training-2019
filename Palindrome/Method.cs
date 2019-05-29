using System;

namespace Palindrome
{
    public static class Method
    {
        public static void DisplayPalindrome(string disp)
        {
            bool isPalindrome = true;
            string str = disp.Replace(" ", "");
            for (int i = 0; i <= str.Length / 2; i++)
            {
                if (str[i] == str[str.Length - (i + 1)])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine("{0}: / Result is: {1}", disp, isPalindrome);
        }

    }
}
