using System;
using System.Collections.Generic;
using System.Text;

namespace FooBar
{
    public class FooBarClass
    {
        public int ConvertNum(string str)
        {
            int num = Convert.ToInt32(str);
            return num;
        }

        public void CheckInput(int num)
        {
            string[] msg = { "FOO", "BAR", "FOOBAR" };
            if (num % 3 == 0)
            {
                Console.WriteLine(msg[0]);
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine(msg[1]);
            }
            else if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine(msg[2]);
            }
            else if (num % 3 != 0 || num % 5 != 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public bool IsNotNegative(int num)
        {
            bool b;
            if (num > 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
    }
}
