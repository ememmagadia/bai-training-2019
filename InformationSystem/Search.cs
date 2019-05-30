using System;
using System.Collections.Generic;
using System.Linq;

namespace InformationSystem
{
    class Search
    {
        public static void getSearch(string choice, IList<Person> personList)
        {
            string search = "";
            string search2 = "";
            search = getSearchType(search);
            if (search == "n")
            {
                search2 = getSearchValue(search2);
                var searchResult = personList.Where(s => s.name == search2);
                displayList(searchResult);
            }
            else if (search=="a")
            {
                search2 = getSearchValue(search2);
                int i = 0;
                if (int.TryParse(search2, out i))
                {
                    var searchResult = personList.Where(s => s.age == i);
                    displayList(searchResult);
                }
            }
            else
            {
                search2 = getSearchValue(search2);
                var searchResult = personList.Where(s => s.gender == search2);
                displayList(searchResult);
            }   
        }

        public static void getSearch(string choice, IList<Animal> animalList)
        {
            string search = "";
            string search2 = "";
            search = getSearchType(search);
            if (search == "n")
            {
                search2 = getSearchValue(search2);
                var searchResult = animalList.Where(s => s.name == search2);
                displayList(searchResult);
            }
            else if (search == "a")
            {
                search2 = getSearchValue(search2);
                int i = 0;
                if (int.TryParse(search2, out i))
                {
                    var searchResult = animalList.Where(s => s.age == i);
                    displayList(searchResult);
                }
            }
            else
            {
                search2 = getSearchValue(search2);
                var searchResult = animalList.Where(s => s.gender == search2);
                displayList(searchResult);
            }
        }
        private static void displayList(IEnumerable<Person> searchResult)
        {
            foreach (var list in searchResult)
            {
                Console.WriteLine("{0} is {1} years old and is a {2}", list.name, list.age, list.gender);
            }
        }

        private static void displayList(IEnumerable<Animal> searchResult)
        {
            foreach (var list in searchResult)
            {
                Console.WriteLine("{0} is {1} years old and is a {2}", list.name, list.age, list.gender);
            }
        }

        private static string getSearchValue(string search2)
        {
            Console.Write("Input search: ");
            search2 = Console.ReadLine();
            return search2;
        }

        private static string getSearchType(string search)
        {
            while (true)
            {
                Console.Write("Search name, age, or gender? (n/a/g): ");
                search = Console.ReadLine();
                if (search == "a" || search == "n" || search == "g") break;
                else Console.WriteLine("Invalid! Try Again!");
            }
            return search;
        }
    }
}
