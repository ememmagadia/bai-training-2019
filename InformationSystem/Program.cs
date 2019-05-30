using System;
using System.Collections.Generic;
using System.Linq;

namespace InformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> personList = addPersonList();
            IList<Animal> animalList = addAnimalList();
            string choice = "";
            string choice2 = "";
            choice = getPersonAnimal(choice);
            choice2 = allOrSearch(choice2);

            if (choice == "p" && choice2 == "g") displayList(personList);
            else if (choice == "a" && choice2 == "g") displayList(animalList);
            else
            {
                if (choice == "p") Search.getSearch(choice, personList);
                else if (choice == "a") Search.getSearch(choice, animalList);
            }
            
        }

        

        private static string allOrSearch(string choice2)
        {
            while (true)
            {
                Console.WriteLine("Get All or Search? (g/s)");
                choice2 = Console.ReadLine();
                if (choice2 == "g" || choice2 == "s") break;
                else Console.WriteLine("Invalid! Try Again!");
            }
            return choice2;
        }

        private static string getPersonAnimal(string choice)
        {
            while (true)
            {
                Console.WriteLine("Person or Animal? (p/a)");
                choice = Console.ReadLine();
                if (choice == "a" || choice == "p") break;
                else Console.WriteLine("Invalid! Try Again!");
            }
            return choice;
        }

        private static IList<Animal> addAnimalList()
        {
            return new List<Animal>()
            {
                new Animal() {name="Chico", age=2, gender="Male"},
                new Animal() {name="Goldy", age=8, gender="Female"},
                new Animal() {name="Whity", age=7, gender="Female"},
                new Animal() {name="Brownie", age=5, gender="Male"},
                new Animal() {name="Blacky", age=11, gender="Male"},
            };
        }

        private static IList<Person> addPersonList()
        {
            return new List<Person>()
            {
                new Person() {name="Jelmarose", age=16, gender="Male"},
                new Person() {name="Marc", age=10, gender="Male"},
                new Person() {name="Felix", age=69, gender="Male"},
                new Person() {name="Dino", age=29, gender="Male"},
                new Person() {name="Charles", age=14, gender="Male"},
                new Person() {name="Arnold", age=12, gender="Male"},
                new Person() {name="Ellah", age=22, gender="Female"},
                new Person() {name="Kyla", age=13, gender="Female"},
                new Person() {name="Melrose", age=1, gender="Female"},
                new Person() {name="Jasper", age=15, gender="Male"},
                new Person() {name="Aaron", age=15, gender="Male"},
            };
        }

        private static void displayList(IList<Animal> animalList)
        {
            foreach (var list in animalList)
            {
                Console.WriteLine("{0} is {1} years old and is a {2}", list.name, list.age, list.gender);
            }
        }

        private static void displayList(IList<Person> personList)
        {
            foreach (var list in personList)
            {
                Console.WriteLine("{0} is {1} years old and is a {2}", list.name, list.age, list.gender);
            }
        }
    }
}
