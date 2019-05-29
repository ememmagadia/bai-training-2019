using System;

namespace ConsoleApp2
{
    public class A
    {
        private int value = 10;
        public class B : A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());
        }
    }
}
