using System;

namespace Calculator
{
    class Calculator
    {
        public void ComputeStringMenu()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("* Enter a string to be computed     *");
            Console.WriteLine("*************************************");
            Console.WriteLine("* (+) for addition                  *\n" +
                              "* (-) for subtraction               *\n" +
                              "* (*) for multiplication            *\n" +
                              "* (/) for division                  *\n");
            Console.WriteLine("*************************************");
            Console.WriteLine("* Example: 1 + 2 - 3                *");
            Console.WriteLine("*************************************");
            Console.WriteLine("\nType x and press enter to return to main menu");
            string input = "";
            while (input != "x")
            {
                Console.Write("\nEnter option: ");
                input = Console.ReadLine();
                if (input == "x")
                {
                    DisplayMainMenu();
                    break;
                }
                else
                {
                    Parser p = new Parser();
                    p.Parse(input);
                    break;
                }
            }
        }
        public void ComputeTwoNumbersMenu()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("* Compute with two numbers          *");
            Console.WriteLine("*************************************");
            Console.WriteLine("* 1 - Addition                      *");
            Console.WriteLine("* 2 - Subtraction                   *");
            Console.WriteLine("* 3 - Multiplication                *");
            Console.WriteLine("* 4 - Division                      *");
            Console.WriteLine("* x - Return to main menu           *");
            Console.WriteLine("*************************************");

            string input = "";
            while (input != "x")
            {
                Console.Write("\nEnter option: ");
                input = Console.ReadLine();
                int number;
                if (int.TryParse(input, out number))
                {
                    if (number == 1)
                    {
                        Addition a = new Addition();
                        a.AdditionMenu();
                        break;
                    }
                    else if (number == 2)
                    {
                        Subtraction s = new Subtraction();
                        s.SubtractionMenu();
                        break;
                    }
                    else if (number == 3)
                    {
                        Multiplication m = new Multiplication();
                        m.MultiplicationMenu();
                        break;
                    }
                    else if (number == 4)
                    {
                        Division d = new Division();
                        d.DivisionMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                }
                else
                {
                    if (input == "x")
                    {
                        DisplayMainMenu();
                        break;
                    }
                    else Console.WriteLine("Invalid input! Please enter a number. \n");
                }
            }
        }

        public void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculator");
            Console.WriteLine("*************************************");
            Console.WriteLine("* 1 - Compute with two numbers      *");
            //Console.WriteLine("* 2 - Enter a string to be computed *");
            Console.WriteLine("* x - Exit program                  *");
            Console.WriteLine("*************************************");

            string input = "";
            while (input != "x")
            {
                Console.Write("\nEnter option: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (number == 1)
                    {
                        ComputeTwoNumbersMenu();
                        break;
                    }
                    /*else if (number == 2)
                    {
                        ComputeStringMenu();
                        break;
                    }*/
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                }
                else
                {
                    if (input == "x") Console.WriteLine("Goodbye!");
                    else Console.WriteLine("Invalid input! Please enter a number. \n");
                }
            }

        }
        //static void Main(string[] args)
        public static void CalculatorMain()
        {
            Calculator c = new Calculator();
            c.DisplayMainMenu();
        }
    }
}
