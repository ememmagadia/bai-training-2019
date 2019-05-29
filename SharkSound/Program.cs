using System;

namespace SharkSound
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations comp = new Operations();
            Console.Write("Input the first number:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number:");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the desired operation(+,-,*,/):");
            string op = Console.ReadLine();
            if (string.Equals(op, "+"))
            {
                Console.WriteLine("The result is {0}",comp.Add(Num1, Num2));
            }
            else if(string.Equals(op, "-"))
            {
                Console.WriteLine("The result is {0}", comp.Sub(Num1, Num2));
            }
            else if(string.Equals(op, "*"))
            {
                Console.WriteLine("The result is {0}", comp.Mult(Num1, Num2));
            }
            else if (string.Equals(op, "/"))
            {
                Console.WriteLine("The result is {0}", comp.Div(Num1, Num2));
            }
            else
            {
                Console.WriteLine("Try again and input a valid operation");
            }




            //string x = "civic";
            //for (int i=0; i <= x.Length - 1; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}
        }
    }
}
