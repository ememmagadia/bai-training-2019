using System;
using System.Collections.Generic;

namespace Palindrome
{
	public class Program
	{
		public static void Main()
		{
			List<string> ListOfPalindrome = new List<string>(); 
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

			int len = ListOfPalindrome.Count;
			for (int i = 0; i < len; i++)
			{
				Console.WriteLine("Word : " + ListOfPalindrome[i] + " / Result : " + palin(ListOfPalindrome[i]));
			}

			Console.ReadKey();
		}

		public static string palin (string word)
		{
			string result = "True";
			string newWord = word.Replace(" ", "");
			int len = newWord.Length;
			for(int i = 0; i < len; i++)
			{
				if(newWord[i]==newWord[len-1-i])
				{
					result = "True";
				}
				else
				{
					result = "False";
					break;
				}
			}

			return result;


		}
	}
}
