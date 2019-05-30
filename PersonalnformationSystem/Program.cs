using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PersonalnformationSystem
{ 
    class Program : ISearch
    {
        List<Person> personsList = new List<Person>()
            {
                new Person{
                    ID = "ee79d76b",
                    Name = "Gary Unwin",
                    Age = 24,
                    Gender = "Male"
                },
                new Person{
                    ID = "bfae621c",
                    Name = "Roxanne Morton",
                    Age = 23,
                    Gender = "Female"
                },
                new Person{
                    ID = "b79a650d",
                    Name = "Harry Hart",
                    Age = 53,
                    Gender = "Male"
                },
                new Person{
                    ID = "b59a250d",
                    Name = "James Spencer",
                    Age = 48,
                    Gender = "Male"
                },
                new Person{
                    ID = "b1ca650d",
                    Name = "Merlin",
                    Age = 51,
                    Gender = "Male"
                },
            };

        List<Animal> animalsList = new List<Animal>()
            {
                new Animal{
                    ID = "eq79d76b",
                    Name = "Polly",
                    Age = 5,
                    Gender = "Female"
                },
                new Animal{
                    ID = "bqae621c",
                    Name = "Chris",
                    Age = 11,
                    Gender = "Male"
                },
                new Animal{
                    ID = "bq9a650d",
                    Name = "Stephanie",
                    Age = 7,
                    Gender = "Female"
                },
                new Animal{
                    ID = "b7qa650d",
                    Name = "Luciel",
                    Age = 21,
                    Gender = "Male"
                },
                new Animal{
                    ID = "b79a62jd",
                    Name = "Princess",
                    Age = 12,
                    Gender = "Female"
                },
            };

        public void SearchByName(string Name, string Category)
        {
            Program p = new Program();
            if (Category.Equals("Person"))
            {
               Console.WriteLine("********************************************");
               Console.Write("Searched for {0}: ", Name);

                var results = from person in p.personsList
                              where person.Name.Contains(Name)
                              select person;

               Console.WriteLine(" {0} results found.", results.Count());
               if(results.Count() == 0)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayPersonsMenu();
                }
               else
                {
                   foreach(var result in results)
                    {
                         Console.WriteLine("********************************************");
                         Console.WriteLine("Name: {0}", result.Name);
                         Console.WriteLine("Age: {0}", result.Age);
                         Console.WriteLine("Gender: {0}", result.Gender);
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayPersonsMenu();
                }
            }
            else
            {
                Console.WriteLine("********************************************");
                Console.Write("Searched for {0}: ", Name);

                var results = from animal in p.animalsList
                              where animal.Name.Contains(Name)
                              select animal;

                Console.WriteLine(" {0} results found.", results.Count());
                if (results.Count() == 0)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayAnimalsMenu();
                }
                else
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Name: {0}", result.Name);
                        Console.WriteLine("Age: {0}", result.Age);
                        Console.WriteLine("Gender: {0}", result.Gender);
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayAnimalsMenu();
                }
                Console.ReadLine();
            }
        }

        public void SearchByAge(int Age, string Category)
        {
            Program p = new Program();
            if (Category.Equals("Person"))
            {
                Console.WriteLine("********************************************");
                Console.Write("Searched for persons aged {0}: ", Age);

                var results = from person in p.personsList
                              where person.Age == Age
                              select person;

                Console.WriteLine(" {0} results found.", results.Count());
                if (results.Count() == 0)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayPersonsMenu();
                }
                else
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Name: {0}", result.Name);
                        Console.WriteLine("Age: {0}", result.Age);
                        Console.WriteLine("Gender: {0}", result.Gender);
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayPersonsMenu();
                }
            }
            else
            {
                Console.WriteLine("********************************************");
                Console.Write("Searched for animals aged {0}: ", Age);

                var results = from animal in p.animalsList
                              where animal.Age == Age
                              select animal;

                Console.WriteLine(" {0} results found.", results.Count());
                if (results.Count() == 0)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayAnimalsMenu();
                }
                else
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Name: {0}", result.Name);
                        Console.WriteLine("Age: {0}", result.Age);
                        Console.WriteLine("Gender: {0}", result.Gender);
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayAnimalsMenu();
                }
            }
        }

        public void SearchByGender(string Gender, string Category)
        {
            Program p = new Program();
            if (Category.Equals("Person"))
            {
                Console.WriteLine("********************************************");
                Console.Write("Searched for persons with gender `{0}`: ", Gender);

                var results = from person in p.personsList
                              where person.Gender.Equals(Gender)
                              select person;

                Console.WriteLine(" {0} results found.", results.Count());
                if (results.Count() == 0)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayPersonsMenu();
                }
                else
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Name: {0}", result.Name);
                        Console.WriteLine("Age: {0}", result.Age);
                        Console.WriteLine("Gender: {0}", result.Gender);
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayPersonsMenu();
                }
            }
            else
            {
                Console.WriteLine("********************************************");
                Console.Write("Searched for animals with gender `{0}`: ", Gender);

                var results = from animal in p.animalsList
                              where animal.Gender.Equals(Gender)
                              select animal;

                Console.WriteLine(" {0} results found.", results.Count());
                if (results.Count() == 0)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayAnimalsMenu();
                }
                else
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Name: {0}", result.Name);
                        Console.WriteLine("Age: {0}", result.Age);
                        Console.WriteLine("Gender: {0}", result.Gender);
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    p.DisplayAnimalsMenu();
                }
            }
        }
        public void DisplayAllRecords(string Category)
        {
            Program p = new Program();
            if (Category.Equals("Person"))
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("Persons Records");
                foreach (var person in p.personsList)
                {
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Name: {0}", person.Name);
                        Console.WriteLine("Age: {0}", person.Age);
                        Console.WriteLine("Gender: {0}", person.Gender);
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                p.DisplayPersonsMenu();
            }
            else
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("Animal Records");
                foreach (var animal in p.animalsList)
                {
                    Console.WriteLine("********************************************");
                    Console.WriteLine("Name: {0}", animal.Name);
                    Console.WriteLine("Age: {0}", animal.Age);
                    Console.WriteLine("Gender: {0}", animal.Gender);
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                p.DisplayAnimalsMenu();
            }

            
        }
        public void DisplayAnimalsMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("**  You are checking Animals information  **");
            Console.WriteLine("********************************************");
            Console.WriteLine("** What do you want to do?                **");
            Console.WriteLine("** 1 - View all records                   **");
            Console.WriteLine("** 2 - Search records                     **");
            Console.WriteLine("** 0 - Return to main menu                **");
            Console.WriteLine("********************************************");


            string option = "";
            while (!option.Equals("0"))
            {
                Console.Write("Enter option >> ");
                option = Console.ReadLine();
                if (option.Equals("1"))
                {
                    DisplayAllRecords("Animal");
                    break;
                }
                else if (option.Equals("2"))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("******************");
                    Console.WriteLine("**  Search by:  **");
                    Console.WriteLine("******************");
                    Console.WriteLine("**  - Name      **");
                    Console.WriteLine("**  - Age       **");
                    Console.WriteLine("**  - Gender    **");
                    Console.WriteLine("******************");

                    string searchBy = "";
                    while (!searchBy.Equals("Name")
                        || !searchBy.Equals("name")
                        || !searchBy.Equals("Age")
                        || !searchBy.Equals("age")
                        || !searchBy.Equals("Gender")
                        || !searchBy.Equals("gender"))
                    {
                        Console.Write("Enter option >> ");
                        searchBy = Console.ReadLine();


                        if (searchBy.Equals("Name")
                        || searchBy.Equals("name"))
                        {
                            Console.Write("Enter name: ");
                            string query = Console.ReadLine();
                            SearchByName(query, "Animal");
                            break;
                        }
                        else if (searchBy.Equals("Age")
                        || searchBy.Equals("age"))
                        {
                            string query = "";
                            int age;
                            while (!int.TryParse(query, out age))
                            {
                                Console.Write("Enter age: ");
                                query = Console.ReadLine();
                                if (int.TryParse(query, out age))
                                {
                                    SearchByAge(age, "Animal");
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid age!\n");
                                }
                            }
                            break;
                        }
                        else if (searchBy.Equals("Gender")
                        || searchBy.Equals("gender"))
                        {
                            Console.Write("Enter gender: ");
                            string query = Console.ReadLine();
                            SearchByGender(query, "Animal");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option! \n");
                        }
                    }

                }
                else if (option.Equals("0"))
                {
                    DisplayMainMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option! \n");
                }
            }
        }
        public void DisplayPersonsMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("**  You are checking Persons information  **");
            Console.WriteLine("********************************************");
            Console.WriteLine("** What do you want to do?                **");
            Console.WriteLine("** 1 - View all records                   **");
            Console.WriteLine("** 2 - Search records                     **");
            Console.WriteLine("** 0 - Return to main menu                **");
            Console.WriteLine("********************************************");

            string option = "";
            while(!option.Equals("0"))
            {
                Console.Write("Enter option >> ");
                option = Console.ReadLine();
                if (option.Equals("1"))
                {
                    DisplayAllRecords("Person");
                    break;
                }
                else if (option.Equals("2"))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("******************");
                    Console.WriteLine("**  Search by:  **");
                    Console.WriteLine("******************");
                    Console.WriteLine("**  - Name      **");
                    Console.WriteLine("**  - Age       **");
                    Console.WriteLine("**  - Gender    **");
                    Console.WriteLine("******************");

                    string searchBy = "";
                    while (!searchBy.Equals("Name")
                        || !searchBy.Equals("name")
                        || !searchBy.Equals("Age")
                        || !searchBy.Equals("age")
                        || !searchBy.Equals("Gender")
                        || !searchBy.Equals("gender"))
                    {
                        Console.Write("Enter option >> ");
                        searchBy = Console.ReadLine();


                        if (searchBy.Equals("Name")
                        || searchBy.Equals("name"))
                        {
                            Console.Write("Enter name: ");
                            string query = Console.ReadLine();
                            SearchByName(query,"Person");
                            break;
                        }
                        else if (searchBy.Equals("Age")
                        || searchBy.Equals("age"))
                        {
                            string query = "";
                            int age;
                            while(!int.TryParse(query, out age))
                            {
                                Console.Write("Enter age: ");
                                query = Console.ReadLine();
                                if (int.TryParse(query, out age))
                                {
                                    SearchByAge(age, "Person");
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid age!\n");
                                }
                            }
                            break;
                        }
                        else if (searchBy.Equals("Gender")
                        || searchBy.Equals("gender"))
                        {
                            Console.Write("Enter gender: ");
                            string query = Console.ReadLine();
                            SearchByGender(query, "Person");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option! \n");
                        }
                    }
                    
                }
                else if (option.Equals("0"))
                {
                    DisplayMainMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option! \n");
                }
            }
        }
        public void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("**  Person and Animal Information System  **");
            Console.WriteLine("********************************************");
            Console.WriteLine("** Would you like to check the record of  **");
            Console.WriteLine("** a person or an animal?                 **");
            Console.WriteLine("********************************************");

            string option = "";

            while (!option.Equals("exit"))
            {
                Console.Write("Enter option >> ");
                option = Console.ReadLine();
                if (option.Equals("person") || option.Equals("Person"))
                {
                    DisplayPersonsMenu();
                    break;
                }
                else if (option.Equals("animal") || option.Equals("Animal"))
                {
                    DisplayAnimalsMenu();
                    break;
                }
                else if (option.Equals("exit") || option.Equals("Exit"))
                {
                    Console.WriteLine("Goodbye!");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Input not valid! Please enter a valid option.");
                    Console.WriteLine("Type `exit` and press enter if you wish to quit.");
                }
            }


            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.DisplayMainMenu();
            
        }

        
    }
}
