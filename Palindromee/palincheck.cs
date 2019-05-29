using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromee
{
    public class palincheck
    {
        public bool palinloop(string x)
        {
            x = x.Replace(" ", String.Empty);
            bool check = true;
            for (int i = 0; i <= x.Length - 1; i++)
            {
                if (string.Equals(x[i], x[x.Length - 1 - i]) == false)
                {
                    check= false;
                }
            }
            return check;
        }
    }
}
