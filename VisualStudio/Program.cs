using System;

namespace VisualStudio
{
    class Program
    {
        public int Sum(int firstNo, int secondNo)
        {
            return firstNo + secondNo;
        }
        public int Product(int firstNo, int secondNo)
        {
            return firstNo * secondNo;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Program p = new Program();
            int product = p.Product(7, 95);
            int sum = p.Sum(213, 812);
            Console.WriteLine("The product of 7 and 95 is " + product);
            Console.WriteLine("The sum of 213 and 812 is " + sum);
           
        }
    }
}
