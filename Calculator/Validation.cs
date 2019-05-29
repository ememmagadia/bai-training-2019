using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Validation
    {
        public String validate(String result)
        {
            bool ValidNumber = false;
            int Number;
            if (int.TryParse(result, out Number))
            {
                ValidNumber = true;
            }
            else
            {
                Console.WriteLine("Please input number" + "\n" + "Please Try Again");
                System.Environment.Exit(1);
            }

            return result;
        }
    }
}
