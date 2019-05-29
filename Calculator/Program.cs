using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Add(List<int> listOfNumber)
        {
            int result = 0;

            for (int i = 0; i < listOfNumber.Count; i++)
            {

                result += listOfNumber[i];
            }
            Console.WriteLine("Result {0}",result);

        }
        static void Subtract(List<int> listOfNumber)
        {
            int result = listOfNumber[listOfNumber.Count - 1];

            for (int i = listOfNumber.Count - 2; i >= 0; i--)
            {

                result -= listOfNumber[i];
            }
            Console.WriteLine("Result {0}", result);
        }
        static void Product(List<int> listOfNumber)
        {
            int result = 1;


            for (int i = 0; i < listOfNumber.Count; i++)
            {
                result *= listOfNumber[i];
            }
            Console.WriteLine("Result {0}", result);
        }
        static void Divide(List<int> listOfNumber)
        {
            double result = (double)listOfNumber[0];
            for (int i = 1; i < listOfNumber.Count; i++)
            {
                result /= listOfNumber[i];
            }
            Console.WriteLine("Result {0}", result);

        }
        static void Main(string[] args)
        {
            Validation validate = new Validation();
            List<int> ListOfNumber = new List<int>();
            Console.WriteLine("Please Enter How Many Number You Want To Use ");
            String HowManyNumber = Console.ReadLine();
            int x = Int32.Parse(validate.validate(HowManyNumber));
            int i = 0;
            while (i < x)
            {
                Console.WriteLine("Enter Your Number");
                String EnterYourNumber = Console.ReadLine();
                int number = Int32.Parse(validate.validate(EnterYourNumber));
                ListOfNumber.Add(number);
                i++;
            }
            Console.WriteLine("List of Operator");
            Console.WriteLine("Type 1 to ADD");
            Console.WriteLine("Type 2 to SUBTRACT");
            Console.WriteLine("Type 3 to MULTIPLY");
            Console.WriteLine("Type 4 to DIVIDE");
            Console.WriteLine("==================================================================");
            Console.WriteLine("Select a Operator");
            String Operator = Console.ReadLine();
            int SelectOperator = Int32.Parse(validate.validate(Operator));
          
                if (SelectOperator == 1)
                {
                    Program.Add(ListOfNumber);
                }
                else if (SelectOperator == 2)
                {
                    Program.Subtract(ListOfNumber);
                }
                else if (SelectOperator == 3)
                {
                    Program.Product(ListOfNumber);
                }
                else if (SelectOperator == 4)
                {
                    Program.Divide(ListOfNumber);
                }
                else
                {
                    Console.WriteLine("Please Enter 1 to 4");
                }
            
           




        }


    }
}
