using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibrary
{
    internal class Calculator
    {
        private int _FNum;
        private int _SNum;


        public Calculator(int FirstNum,int SecondNum)
        {
            _FNum = FirstNum;
            _SNum = SecondNum;
        }

        public void Add()
        {
            int total = _FNum + _SNum;
            Console.WriteLine("Answer:"+total);
            return;
        }
        public void Subtract()
        {
            int total = _FNum - _SNum;
            Console.WriteLine("Answer:" + total);
            return;
        }

        public void Multiply()
        {
            int total = _FNum * _SNum;
            Console.WriteLine("Answer:" + total);

            return;
        }

        public void Divide()
        {
            int total = _FNum / _SNum;
            Console.WriteLine("Answer:" + total);

            return;
        }

    }
}
