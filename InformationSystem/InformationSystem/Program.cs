using System;
using System.Collections.Generic;


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
            IList<Pips> ListofPeople = new List<Pips>();
            {
                new Pips() { PersonName = "Jelmarose", PersonAge = 21, PersonGender = "Female" };
                new Pips() { PersonName = "Marc", PersonAge = 21, PersonGender = "Male" };
                new Pips() { PersonName = "Felix", PersonAge = 21, PersonGender = "Male" };
                new Pips() { PersonName = "Dino", PersonAge = 21, PersonGender = "Male" };
                new Pips() { PersonName = "Charles", PersonAge = 21, PersonGender = "Male" };
                new Pips() { PersonName = "Arnold", PersonAge = 21, PersonGender = "Male" };
                new Pips() { PersonName = "Aaron", PersonAge = 21, PersonGender = "Male" };
                new Pips() { PersonName = "Jasper", PersonAge = 21, PersonGender = "Male" };
                new Pips() { PersonName = "Melrose", PersonAge = 21, PersonGender = "Female" };
                new Pips() { PersonName = "Kyla", PersonAge = 21, PersonGender = "Female" };
                new Pips() { PersonName = "Ella", PersonAge = 21, PersonGender = "Female" };

            }
            //do
            //{
            Console.WriteLine("What do you want to do? || Press 1 to Get All || Press 2 to Search");
            opt = Console.ReadLine();
            if (opt.StartsWith("1"))
            {
                foreach (Pips pip in ListofPeople)
                {
                    Console.WriteLine("{0}, {1}, {2}", pip.PersonName, pip.PersonAge, pip.PersonGender);
                }
            }


            else if (opt.StartsWith("2"))
            {
                foreach (var Pips in ListofPeople)
                {
                    Console.WriteLine("{0}, {1}, {2}", Pips.PersonName, Pips.PersonAge, Pips.PersonGender);
                }
            }
            //}
            //while (!opt.startswith("1"));

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
