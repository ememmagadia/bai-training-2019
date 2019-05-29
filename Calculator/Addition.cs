using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Addition
    {
        public int Sum(int minuend1, int minuend2)
        {
            return minuend1 + minuend2;
        }
        public void AdditionMenu()
        {
            Console.Clear();
            char option = 'y';

            while(option != 'n')
            {
                string input1 = "";
                string input2 = "";
                int minuend1, minuend2;

                Console.WriteLine("\nAddition of two numbers \n");

            
                while (!int.TryParse(input1, out minuend1))
                {
                    Console.Write("Enter first minuend: ");
                    input1 = Console.ReadLine();
                    if (int.TryParse(input1, out minuend1)) break;
                    else Console.WriteLine("Please enter a valid number.");
                }

                while (!int.TryParse(input2, out minuend2))
                {
                    Console.Write("Enter second minuend: ");
                    input2 = Console.ReadLine();
                    if (int.TryParse(input2, out minuend2))
                    {
                        Addition n = new Addition();
                        Console.WriteLine("Sum: {0}", n.Sum(minuend1, minuend2));
                    }
                    else Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Add again? [y/n]");
                option = Console.ReadKey().KeyChar;
                if(option == 'n' || option == 'N')
                {
                    Calculator c = new Calculator();
                    c.ComputeTwoNumbersMenu();
                }
            }

        }
    }
}
