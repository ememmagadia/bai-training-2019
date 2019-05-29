using System;

namespace Palindrome
{
    public static class Method
    {
        public static void DisplayPalindrome(string disp)
        {
            bool isPalindrome = true;
            disp = RemoveSpace(disp);

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
                }
            }
            Console.WriteLine("{0}: / Result is: {1}", disp, isPalindrome);
        }

        private static string RemoveSpace(string disp)
        {
            string str = disp.Replace(" ", "");
            return str;
        }
    }
}
