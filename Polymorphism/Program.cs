using System;

namespace Polymorphism
{
    class Program
    {
        void print(int i)
        {
            Console.WriteLine("integer " + i);
        }
        void print(double i)
        {
            Console.WriteLine("double " + i);
        }
        void print(String i)
        {
            Console.WriteLine("String " + i);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print(1);
            p.print(1.2);
            p.print("asdada");
        }
    }
}
