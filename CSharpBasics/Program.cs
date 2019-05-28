using CSharpBasics.FooBar;
using System; //Used to Include the Sytems namespace in the program

namespace CSharpBasics //namespace declarations,  namespace is a collection of classes
{
    class Program // class declaration , contains the data and method definitions that your program uses.
    {
        static void Main(string[] args) //  entry point for all C# programs, The Main method states what the class does when executed.
        {
           
            //Foobar

            var fb = new Foobar();

            int num = Convert.ToInt32(Console.ReadLine());
            
            //fb.GetFoobar(num);

            //fb.GetNestedFoobar(num);

            Console.ReadLine();
        }
    }
}
