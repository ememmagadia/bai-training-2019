using System;
using System.Collections.Generic;
using System.Linq;
namespace InformationSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inp1 = "";
            string Inp2 = "";
            Printer PrintList = new Printer();
            AnimalList al = new AnimalList();
            PersonList pl = new PersonList();
            while (true)
            {
                Console.Write("Persons or Animals: ");
                Inp1 = Console.ReadLine();
                if (Inp1 == "Persons" || Inp1 == "Animals")
                {
                    Console.Write("Which field would you like to search in(Name, Gender, Age)? or give full list of {0} (All)?: ", Inp1);
                    Inp2 = Console.ReadLine();
                    if (Inp2 == "Age" || Inp2 == "Name" || Inp2 == "All" || Inp2 == "Gender")
                    {
                        break;
                    }
                }
                Console.WriteLine("Try Again");
            }
            
            if (string.Equals(Inp2, "All"))
            {
                PrintList.PrintAll(Inp1);
            }
            else
            {
                Console.Write("What {0} would you like to search?: ", Inp2);
                string Inp3 = Console.ReadLine();
                if (Inp1 == "Persons")
                {
                    PrintList.PrintPer(Inp2, Inp3);
                }
                else if(Inp1 == "Animals")
                {
                    PrintList.PrintAni(Inp2, Inp3);
                }
            }
        }
    }
}
