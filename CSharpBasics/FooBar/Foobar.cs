using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics.FooBar
{
    public class Foobar
    {
        public void GetFoobar(int i)
        {

            if (((i % 3) + (i % 5)) == 0)
            {
                Console.WriteLine("Foobar");
                return;
            }
            if (i % 3 == 0)
            {
                Console.WriteLine("Foo");
                return;
            }
            if (i % 5 == 0)
            {
                Console.WriteLine("Bar");
                return;
            }
            Console.WriteLine(i);
        }


        public void GetNestedFoobar(int userInput) {
            for (int i = 1; i <= userInput; i++)
            {
                this.GetFoobar(i);
            }

        }
       
    }
}
