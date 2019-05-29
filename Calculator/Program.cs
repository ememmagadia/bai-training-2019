using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string x = string.Empty;
            do
            {
                Console.WriteLine("1 to Add || 2 to Subtract || 3 to Multiply || 4 to Divide");
                x = Console.ReadLine();
                if (x.StartsWith("1"))
                {
                    AddMenu();
                }
                else if (x.StartsWith("2"))
                {
                    SubMenu();
                }
                else if (x.StartsWith("3"))
                {
                    TimesMenu();
                }
                else if (x.StartsWith("4"))
                {
                    DivideMenu();
                }

            }

            while (!x.StartsWith("1") || !x.StartsWith("2") || !x.StartsWith("3") || !x.StartsWith("4"));
        }

        private static void DivideMenu()
        {
            string firstNum;
            int firstcheck = 0;
            string secondNum;
            int secondcheck = 0;
            int total = 0;
            bool containsText = false;
            bool containsText2 = false;

            do
            {
                Console.Write("Enter First Number: ");
                firstNum = Console.ReadLine();
                containsText = firstNum.Any(c => char.IsLetter(c));

                Console.Write("Enter Second Number: ");
                secondNum = Console.ReadLine();
                containsText2 = secondNum.Any(c => char.IsLetter(c));
                int.TryParse(firstNum, out firstcheck);
                int.TryParse(secondNum, out secondcheck);

                total = firstcheck / secondcheck;
                if (containsText)
                {
                    Console.WriteLine("Invalid Input for First Number!");
                    containsText = false;
                }
                if (containsText2)
                {
                    Console.WriteLine("Invalid Input for Second Number!");
                    containsText = false;
                }
                else
                {
                    Console.WriteLine(" " + firstcheck + " /" + " " + secondcheck + " " + " = " + total);
                }
            }
            while (containsText || containsText2);
        }

        private static void TimesMenu()
        {
            string firstNum;
            int firstcheck = 0;
            string secondNum;
            int secondcheck = 0;
            int total = 0;
            bool containsText = false;
            bool containsText2 = false;

            do
            {
                Console.Write("Enter First Number: ");
                firstNum = Console.ReadLine();
                containsText = firstNum.Any(c => char.IsLetter(c));

                Console.Write("Enter Second Number: ");
                secondNum = Console.ReadLine();
                containsText2 = secondNum.Any(c => char.IsLetter(c));
                int.TryParse(firstNum, out firstcheck);
                int.TryParse(secondNum, out secondcheck);

                total = firstcheck * secondcheck;
                if (containsText)
                {
                    Console.WriteLine("Invalid Input for First Number!");
                    containsText = false;
                }
                if (containsText2)
                {
                    Console.WriteLine("Invalid Input for Second Number!");
                    containsText = false;
                }
                else
                {
                    Console.WriteLine(" " + firstcheck + " X" + " " + secondcheck + " " + " = " + total);
                }
            }
            while (containsText || containsText2);
        }

        public static void SubMenu()
        {
            string firstNum;
            int firstcheck = 0;
            string secondNum;
            int secondcheck = 0;
            int total = 0;
            bool containsText = false;
            bool containsText2 = false;

            do
            {
                Console.Write("Enter First Number: ");
                firstNum = Console.ReadLine();
                containsText = firstNum.Any(c => char.IsLetter(c));

                Console.Write("Enter Second Number: ");
                secondNum = Console.ReadLine();
                containsText2 = secondNum.Any(c => char.IsLetter(c));
                int.TryParse(firstNum, out firstcheck);
                int.TryParse(secondNum, out secondcheck);

                total = firstcheck - secondcheck;
                if (containsText)
                {
                    Console.WriteLine("Invalid Input for First Number!");
                    containsText = false;
                }
                if (containsText2)
                {
                    Console.WriteLine("Invalid Input for Second Number!");
                    containsText = false;
                }
                else
                {
                    Console.WriteLine(" " + firstcheck + " -" + " " + secondcheck + " " + " = " + total);
                }
            }
            while (containsText || containsText2);
        }

        public static void AddMenu()
        {

            string firstNum;
            int firstcheck = 0;
            string secondNum;
            int secondcheck = 0;
            int total = 0;
            bool containsText = false;
            bool containsText2 = false;

            do
            {
                Console.Write("Enter First Number: ");
                firstNum = Console.ReadLine();
                containsText = firstNum.Any(c => char.IsLetter(c));
                
                Console.Write("Enter Second Number: ");
                secondNum = Console.ReadLine();
                containsText2 = secondNum.Any(c => char.IsLetter(c));
                int.TryParse(firstNum, out firstcheck);
                int.TryParse(secondNum, out secondcheck);
        
                total = firstcheck + secondcheck;                
                if (containsText)
                {
                    Console.WriteLine("Invalid Input for First Number!");
                    containsText = false;
                }
                if (containsText2)
                {
                    Console.WriteLine("Invalid Input for Second Number!");
                    containsText = false;
                }
                else
                {
                    Console.WriteLine(" " + firstcheck + " +" + " " + secondcheck + " " + " = " + total);
                }
            }
            while (containsText || containsText2);
        }
}
}
