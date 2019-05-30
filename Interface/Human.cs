using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Human : IMove, IPlay
    {
        public string Name;
        public string Running;
        public string Walking;
        public void Basketball()
        {
           Console.WriteLine("{0} Play Basketball ", Name);
        }

        public int Points(int HowMuch)
        {
            Console.WriteLine("My Score {0} ", HowMuch);

            return HowMuch;

        }

        public void Run()
        {
            Console.WriteLine("I'm {0}  ", Running);
        }

        public string Shout(string shout)
        {
            Console.WriteLine("I'm Shouting {0}", shout);

            return shout;
        }

        public void Walk()
        {
            Console.WriteLine("I'm {0}", Walking);
        }
    }
}
