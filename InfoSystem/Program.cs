using System;
using System.Collections.Generic;
using static InformationSystem.Details;

namespace InformationSystem
{
    class Program
    {
        public static void Main(string[] args)
        {



            string x;
            do
            {
                Console.WriteLine("Person or Animal? || Press 1 for Persons || Press 2 for Animals");
                x = Console.ReadLine();

                if (x.StartsWith("1"))
                {
                    PersonMenu();
                }
                else if (x.StartsWith("2"))
                {
                    AnimalMenu();
                }
                else
                {
                    Console.WriteLine("Please press 1 or 2 only");
                    Console.WriteLine("");
                }
            }
            while (!x.StartsWith("1") || !x.StartsWith("2"));
        }

        public static void AnimalMenu()
        {

        }

        public static void PersonMenu()
        {
            string opt;
            List<Pips> people = Persons.LoadPersonData();
            Console.WriteLine("What do you want to do? || Press 1 to Get All || Press 2 to Search");
            opt = Console.ReadLine();
            if (opt.StartsWith("1"))
            {
                foreach (var person in people)
                {
                    Console.WriteLine("{0}, {1}, {2}", person.PersonName, person.PersonAge, person.PersonGender);
                }
            }


            else if (opt.StartsWith("2"))
            {
                string search = "";
                Console.WriteLine("Search the Name of The Person: ");
                search = Console.ReadLine();
                foreach (var person in people)
                {


                }





                foreach (var person in people)
                {
                    Console.WriteLine("{0}, {1}, {2}", person.PersonName, person.PersonAge, person.PersonGender);
                }
            }
            //}
            //while (!opt.startswith("1"));

        }
        public static void searchList(string searchType, List<Pips> ListofPeople)
        {




        }

        private static void AnimalList()
        {
            IList<Animals> ListofAnimal = new List<Animals>();
            {
                new Animals() { AnimalName = "Dogman", AnimalAge = 5, AnimalGender = "Male" };
                new Animals() { AnimalName = "CatMan", AnimalAge = 2, AnimalGender = "Male" };
                new Animals() { AnimalName = "PigMan", AnimalAge = 3, AnimalGender = "Male" };
                new Animals() { AnimalName = "Dogman", AnimalAge = 5, AnimalGender = "Male" };
                new Animals() { AnimalName = "Dogman", AnimalAge = 5, AnimalGender = "Male" };
                new Animals() { AnimalName = "Dogman", AnimalAge = 5, AnimalGender = "Male" };
                new Animals() { AnimalName = "Dogman", AnimalAge = 5, AnimalGender = "Male" };
            }
        }

    }

}
