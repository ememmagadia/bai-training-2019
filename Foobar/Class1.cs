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
                    Console.WriteLine("{0} FOOBAR" , Num1);
                }
                else if (Num1 < 0)
                {
                    Console.WriteLine("Please Greater Than zero");
                }
                else if (Num1 % 15 == 0)
                {
                    Console.WriteLine("{0} FOOBAR" , Num1);
                }
                else if (Num1 % 3 == 0)
                {
                    Console.WriteLine("{0} FOO" , Num1);

                }
                else if (Num1 % 5 == 0)
                {
                    Console.WriteLine("{0} BAR", Num1);

                }
                else
                {
                    Console.WriteLine(Num1);
                }
            
           
            return Num1;
        }
    }
}
