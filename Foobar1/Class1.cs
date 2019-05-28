using System;
using System.Collections.Generic;
using System.Text;

namespace Foobar
{
    public class Class1
    {
        public int Number(int Ans)
        {
            {
                if (Ans < 0)
                {
                    Console.WriteLine("Input a positive number");
                }
                else if (Ans % 15 == 0)
                {
                    Console.WriteLine("FOOBAR");
                }
                else if (Ans % 5 == 0)
                {
                    Console.WriteLine("BAR");
                }
                else if (Ans % 3 == 0)
                {
                    Console.WriteLine("FOO");
                }
                else
                {
                    Console.WriteLine(Ans);
                }
            }
            return Ans;
        }
    }
}
