﻿using System;

namespace Foobar
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ValidNumber = false;
            int Number;

            Class1 num = new Class1();
            int i = 0;
            while (i <= 3)
            {


                Console.WriteLine("Enter a number");
                string Input = Console.ReadLine();
                if (int.TryParse(Input, out Number))
                {
                    ValidNumber = true;
                    Number = Int32.Parse(Input);
                    //calling the Number method
                    num.Number(Number);
                    i++;
                }
                else
                {
                    Console.WriteLine("Please input  number");
                }
              
            }
            Console.WriteLine("Press ESC to exit");
            Console.ReadKey();

        }
    }
}
