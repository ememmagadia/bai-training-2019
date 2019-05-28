using System;
using System.Collections.Generic;
using System.Text;

namespace Foobar
{
    class Class1
    {
        public void DetermineFoobar(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Foobar");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Foo");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("bar");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
    class Class2
    {
        public void StartMsg()
        {
            Console.WriteLine("Type 'exit' to close the program.");
        }
        public void InputMsg()
        {
            Console.Write("Enter a number: ");
        }
        public void ErrorMsg()
        {
            Console.WriteLine("Input must be a positive integer.");
        }
    }
}
