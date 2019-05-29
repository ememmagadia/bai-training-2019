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
                double num1=0, num2=0, result;
                Console.WriteLine("Select an Operation, other Input will close the program.");
                Console.WriteLine("[1]Add,[2]Subtract,[3]Multiply,[4]Divide");
                String operation = Console.ReadLine();
                if (!operation.Equals("1") && !operation.Equals("2") && !operation.Equals("3") && !operation.Equals("4"))
                {
                    break;
                }
                
                bool number = false;

                while (!number)
                {
                    try
                    {
                        Console.WriteLine("Enter The first value");
                        num1 = Double.Parse(Console.ReadLine());

                        number = true;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not an number,Try Again");

                    }
                    
                }
                number = false;
                while (!number)
                {
                    try
                    {
                        Console.WriteLine("Enter The second value");
                        num2 = Double.Parse(Console.ReadLine());
                        number = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not an number,Try Again");

                    }
                }
                number = false;

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

            }

        }
    }
}
