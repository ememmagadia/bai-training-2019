using InfoSystem;
using System;
using System.Linq;

namespace InformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person people = new Person();
            Animal animals = new Animal();

            people.LoadPersonList();
            animals.LoadAnimalList();

            while (true)
            {
                Console.WriteLine("Person o Animal?");
                string input = Console.ReadLine();
                input.ToLower();

                if (input.ToLower() != "person" && input.ToLower() != "animal")
                {
                    string ans = InputChecker(input);
                    if (ans != "") { continue; }
                }
                else
                {
                    people.Type = input;
                }

                Console.WriteLine("What do you want to do? \n *Get All <type a>  \n *Search <type s>  \n");
                string input2 = Console.ReadLine();
                input2.ToLower();

                if (input2 == "a")
                {
                    if (input is "person")
                    {
                        people.GetAll();
                    }

                    if (input is "animal")
                    {
                        animals.GetAll();
                    }

                }
                else if (input2 == "s")
                {
                    Console.WriteLine("Search: ");
                    string input3 = Console.ReadLine();

                    people.SearchInput = input3;
                    animals.SearchInput = input3;

                    if (input is "person")
                    {
                        people.Search();
                    }

                    if (input is "animal")
                    {
                        animals.Search();
                    }
                }
                else
                {
                    string ans = InputChecker(input);
                    if (ans != "") { continue; }
                }

            }
        }

        private static string InputChecker(string input)
        {

            Console.WriteLine("Invalid");
            Console.WriteLine("Do you want to enter again? (Y/N)");
            string q = Console.ReadLine();
            string ans = QuesChecker(q);
            return ans;

        }
        public static string QuesChecker(string q)
        {
            if (q.ToLower() == "y")
            {
                return q;
            }
            else
            {
                Environment.Exit(0);
                return "";
            }
        }

    }
}