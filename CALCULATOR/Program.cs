using System;

namespace CALCULATOR
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            bool a=true;
            while (a)
            {
                double num1, num2, result;
                Console.WriteLine("Select an Operation, other Input will close the program.");
                Console.WriteLine("[1]Add,[2]Subtract,[3]Multiply,[4]Divide");
                String operation = Console.ReadLine();
                Console.WriteLine("Enter The first value");
                num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter The second value");
                num2 = Double.Parse(Console.ReadLine());
                if (operation.Equals("1"))
                {
                    Add add = new Add();
                    add.d(num1, num2);
                }
                else if (operation.Equals( "2"))
                {
                    Subtract sub = new Subtract();
                    sub.d(num1, num2);
                }
                else if (operation.Equals("3"))
                {
                    Multiply mul = new Multiply();
                    mul.d(num1, num2);
                }
                else if (operation.Equals( "4"))
                {
                    Divide div = new Divide();
                    div.d(num1, num2);
                }
                else 
                {
                    Console.WriteLine("Invalid Operator, Program will stop");
                    a = false;
                }
            }

        }
    }
}
