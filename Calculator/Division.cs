using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    // inheritance
    public interface Answer
    {
        int GetAnswer();
    }
    public class Quotient : Answer
    {
        public int Dividend;
        public int Divisor;
        public int GetAnswer()
        {
            return Dividend / Divisor;
        }
    }
    public class Division
    {
        public void DivisionMenu()
        {
            Console.Clear();
            char option = 'y';

            while (option != 'n')
            {
                string input1 = "";
                string input2 = "";
                int dividend, divisor;

                Console.WriteLine("\nMultiplication of two numbers \n");


                while (!int.TryParse(input1, out dividend))
                {
                    Console.Write("Enter dividend: ");
                    input1 = Console.ReadLine();
                    if (int.TryParse(input1, out dividend)) break;
                    else Console.WriteLine("Please enter a valid number.");
                }

                while (!int.TryParse(input2, out divisor))
                {
                    Console.Write("Enter divisor: ");
                    input2 = Console.ReadLine();
                    if (int.TryParse(input2, out divisor))
                    {
                        Quotient q = new Quotient
                        {
                            Dividend = dividend,
                            Divisor = divisor
                        };

                        Console.WriteLine("Quotient: {0}", q.GetAnswer());
                    }
                    else Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Divide again? [y/n]");
                option = Console.ReadKey().KeyChar;
                if (option == 'n' || option == 'N')
                {
                    Calculator c = new Calculator();
                    c.ComputeTwoNumbersMenu();
                }
            }
        }
    }
}
