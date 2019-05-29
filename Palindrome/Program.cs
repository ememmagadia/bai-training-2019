using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {

    static List<string> WordPool = new List<string>();

    static void Main(string[] args)
        {
            // Populate WorldPool list
            PopulatePool();

            string NewWord;
            string CompWord;
            bool IsPalindrome;

            Console.Write("Is the word a palindrome?");

            foreach (var Word in WordPool)
            {
                Console.WriteLine(" ");
                Console.Write(Word + " => ");
                NewWord = RemoveWhiteSpace(Word);
                CompWord = ReverseWord(NewWord);
                IsPalindrome = NewWord == CompWord;
                Console.Write(IsPalindrome);
            }

        }

        static string RemoveWhiteSpace(string Word)
        {
            // \s is the regex exp for whitespace
            string Pattern = @"\s";
            string Clean = Regex.Replace(Word, Pattern, "");
            return Clean;
        }

        static string ReverseWord(string Word)
        {
            string Reverse = "";
            char[] LettersArray = Word.ToCharArray();

            for(int index=LettersArray.Length-1; index>=0; index--)
            {
                Reverse += LettersArray[index];
            }

            return Reverse;
        }

        static void PopulatePool()
        {
            WordPool.Add("civic");
            WordPool.Add("deified");
            WordPool.Add("deleveled");
            WordPool.Add("devoved");
            WordPool.Add("dewed");
            WordPool.Add("Hannah");
            WordPool.Add("kayak");
            WordPool.Add("level");
            WordPool.Add("madam");
            WordPool.Add("racecar");
            WordPool.Add("radar");
            WordPool.Add("redder");
            WordPool.Add("refer");
            WordPool.Add("repaper");
            WordPool.Add("reviver");
            WordPool.Add("rotator");
            WordPool.Add("rotor");
            WordPool.Add("sagas");
            WordPool.Add("solos");
            WordPool.Add("sexes");
            WordPool.Add("stats");
            WordPool.Add("tenet");
            WordPool.Add("Dot");
            WordPool.Add("A");
            WordPool.Add("Palindrome");
            WordPool.Add("Race caR");
            WordPool.Add("RaCe CaR");
            WordPool.Add("rAce caR");
        }
    }
}
