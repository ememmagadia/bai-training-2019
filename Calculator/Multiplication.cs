using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    // abstraction?
    abstract class Result
    {
        public abstract int Compute();
    }
    class Product : Result
    {
        public int Multiplicant { set; get; }
        public int Multiplier { set; get; }

        public override int Compute()
        {
            return Multiplicant * Multiplier;
            throw new NotImplementedException();
        }
    }
    public class Multiplication
    {
        public void MultiplicationMenu()
        {
            Console.Clear();
            char option = 'y';

            while (option != 'n')
            {
                string input1 = "";
                string input2 = "";
                int multiplicant, multiplier;

                Console.WriteLine("\nMultiplication of two numbers \n");


                while (!int.TryParse(input1, out multiplicant))
                {
                    Console.Write("Enter multiplicant: ");
                    input1 = Console.ReadLine();
                    if (int.TryParse(input1, out multiplicant)) break;
                    else Console.WriteLine("Please enter a valid number.");
                }

                while (!int.TryParse(input2, out multiplier))
                {
                    Console.Write("Enter multiplier: ");
                    input2 = Console.ReadLine();
                    if (int.TryParse(input2, out multiplier))
                    {
                        Product p = new Product
                        {
                            Multiplicant = multiplicant,
                            Multiplier = multiplier
                        };

                        Console.WriteLine("Product: {0}", p.Compute());
                    }
                    else Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Multiply again? [y/n]");
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
