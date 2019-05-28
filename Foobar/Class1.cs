using System;
using System.Collections.Generic;
using System.Text;

namespace Foobar
{
    public class Class1
    {
        public string Foobar(int a)
        {
            string disp = "";
            if (a % 3 == 0 && a % 5 == 0)
            {
                disp = "Foobar";
            }
            else if (a % 5 == 0)
            {
                disp = "Bar";
            }
            else if (a % 3 == 0)
            {
                disp = "Foo";
            }
            else
            {
                return a.ToString();
            }
            return disp;
        }
    }
}
