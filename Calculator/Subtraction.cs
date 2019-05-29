using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Subtract
    {
        // encapsulation?
        private int subtrahend;
        private int subtractor;

        public int Subtrahend
        {
            get { return subtrahend; }
            set { subtrahend = value; }
        }

        public int Subtractor
        {
            get { return subtractor; }
            set { subtractor = value; }
        }

        public int Difference()
        {
            return subtrahend - subtractor;
        }
    }
    public class Subtraction
    {
        public void SubtractionMenu()
        {
            Console.Clear();
            char option = 'y';

            while (option != 'n')
            {
                string input1 = "";
                string input2 = "";
                int subtrahend, subtractor;

                Console.WriteLine("\nSubtraction of two numbers \n");


                while (!int.TryParse(input1, out subtrahend))
                {
                    Console.Write("Enter subtrahend: ");
                    input1 = Console.ReadLine();
                    if (int.TryParse(input1, out subtrahend)) break;
                    else Console.WriteLine("Please enter a valid number.");
                }

                while (!int.TryParse(input2, out subtractor))
                {
                    Console.Write("Enter subtractor: ");
                    input2 = Console.ReadLine();
                    if (int.TryParse(input2, out subtractor))
                    {
                        Subtract s = new Subtract
                        {
                            Subtrahend = subtrahend,
                            Subtractor = subtractor
                        };

                        Console.WriteLine("Difference: {0}", s.Difference());
                    }
                    else Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Subtract again? [y/n]");
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
