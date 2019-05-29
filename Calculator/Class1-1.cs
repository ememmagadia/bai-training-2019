using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Constants
    {
        protected double N1;
        protected double N2;
        protected double ans;

        public double Constant1
        {
            set
            {
                N1 = value;
            }
        }

        public double Constant2
        {
            set
            {
                N2 = value;
            }
        }
    }

    public class Operations: Constants
    {
        public double Add()
        {
            ans = N1 + N2;
            return ans;
        }
        public double Subtract()
        {
            ans = N1 - N2;
            return ans;
        }
        public double Multiply()
        {
            ans = N1 * N2;
            return ans;
        }
        public double Divide()
        {
            ans = N1 / N2;
            return ans;
        }
    }
}
