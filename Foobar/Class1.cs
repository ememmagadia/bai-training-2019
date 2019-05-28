using System;
using System.Collections.Generic;
using System.Text;

namespace Foobar
{
    public class Class1
    {
        public int Number(int Num1)
        {
                if (Num1 == 0)
                {
                    Console.WriteLine("FOOBAR");
                }
                else if (Num1 < 0)
                {
                    Console.WriteLine("Please Greater Than zero");
                }
                else if (Num1 % 15 == 0)
                {
                    Console.WriteLine("FOOBAR");
                }
                else if (Num1 % 3 == 0)
                {
                    Console.WriteLine("FOO");

                }
                else if (Num1 % 5 == 0)
                {
                    Console.WriteLine("BAR");

                }
                else
                {
                    Console.WriteLine(Num1);
                }
            
           
            return Num1;
        }
    }
}
