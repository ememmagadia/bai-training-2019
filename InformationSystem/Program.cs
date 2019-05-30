using System;

namespace InformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new[]
            {
                new Dog
                {
                    Name = "Chiya",
                    Age = 7,
                    Breed = "Pomeranian"
                },
                new Dog
                {
                    Name = "Gucci",
                    Age = 6,
                    Breed = "Maltese"
                },
                new Dog
                {
                    Name = "Judge",
                    Age = 4,
                    Breed = "Dachshund"
                },
                new Dog
                {
                    Name = "Yuno",
                    Age = 8,
                    Breed = "Golden Retriever"
                },
                new Dog
                {
                    Name = "Vani",
                    Age = 13,
                    Breed = "Labrador"
                },
                new Dog
                {
                    Name = "Artas",
                    Age = 1,
                    Breed = "Chow Chow"
                },
                new Dog
                {
                    Name = "Spike",
                    Age = 2,
                    Breed = "German Shepherd"
                },
                new Dog
                {
                    Name = "Bailey",
                    Age = 8,
                    Breed = "Corgi"
                },
                new Dog
                {
                    Name = "Poncho",
                    Age = 3,
                    Breed = "Pomeranian"
                },
                new Dog
                {
                    Name = "Mako",
                    Age = 5,
                    Breed = "Jack Russel Terrier"
                },
                new Dog
                {
                    Name = "Simba",
                    Age = 5,
                    Breed = "Sheltie"
                }
            };
            Person[] people = new[]
            {
                new Person
                {
                    Name = "Kyla",
                    Age = 18,
                    Gender = "Female"
                },
                new Person
                {
                    Name = "Jelma",
                    Age = 19,
                    Gender = "Female"
                },
                new Person
                {
                    Name = "Marc",
                    Age = 20,
                    Gender = "Male"
                },
                new Person
                {
                    Name = "Lex",
                    Age = 22,
                    Gender = "Male"
                },
                new Person
                {
                    Name = "Dino",
                    Age = 29,
                    Gender = "Male"
                },
                new Person
                {
                    Name = "Charles",
                    Age = 23,
                    Gender = "Male"
                },
                new Person
                {
                    Name = "Arnold",
                    Age = 26,
                    Gender = "Male"
                },
                new Person
                {
                    Name = "Ellah",
                    Age = 23,
                    Gender = "Female"
                },
                new Person
                {
                    Name = "Mel",
                    Age = 19,
                    Gender = "Female"
                },
                new Person
                {
                    Name = "Jasper",
                    Age = 22,
                    Gender = "Male"
                },
                new Person
                {
                    Name = "Aaron",
                    Age = 23,
                    Gender = "Male"
                }
            };

            Dog dog = new Dog();
            Person person = new Person();

            Array recordsArray;

            while (true)
            {
                string category = AskCategory();
                string fields = ValidateCategory(category);

                if (fields != null)
                {
                    string scope = AskScope(fields);
                    if (scope == "all")
                    {
                        if (category == "dog")
                        {
                            recordsArray = dog.QueryAll(dogs);
                        }
                        else
                        {
                            recordsArray = person.QueryAll(people);
                        }
                        PrintArray(recordsArray);
                    }
                    else if (scope == "name" || scope == "age" || scope == "gender" || scope == "breed")
                    {
                        string specific = AskSpecifics(scope);
                        if (category == "dog")
                        {
                            if (scope == "name")
                            {
                                recordsArray = dog.QueryByName(dogs, specific);
                                PrintArray(recordsArray);
                            }
                            else if(scope == "age")
                            {
                                recordsArray = dog.QueryByAge(dogs, int.Parse(specific));
                                PrintArray(recordsArray);
                            }
                            else if(scope == "breed")
                            {
                                recordsArray = dog.QueryByBreed(dogs, specific);
                                PrintArray(recordsArray);
                            }
                        }
                        else
                        {
                            if (scope == "name")
                            {
                                recordsArray = person.QueryByName(people, specific);
                                PrintArray(recordsArray);
                            }
                            else if (scope == "age")
                            {
                                recordsArray = person.QueryByAge(people, int.Parse(specific));
                                PrintArray(recordsArray);
                            }
                            else if (scope == "gender")
                            {
                                recordsArray = person.QueryByGender(people, specific);
                                PrintArray(recordsArray);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice.");
                        Console.WriteLine();
                    }
                }
            }
        }

        static string AskCategory()
        {
            Console.Write("Search for a person or dog? ");
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        static string ValidateCategory(string category)
        {
            if (category == "person" || category == "dog")
            {
                Console.WriteLine();
                string fields;
                switch (category)
                {
                    case "person":
                        fields = "NAME, AGE, GENDER: ";
                        break;
                    default:
                        fields = "NAME, AGE, BREED: ";
                        break;
                }
                return fields;
            }
            else
            {
                Console.WriteLine("Please enter person or dog.");
                Console.WriteLine();
                return null;
            }
        }

        static string AskScope(string fields)
        {
            Console.Write("What do you want to do?\nTo display all records enter ALL\nTo search a specific record enter {0}", fields);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        static string AskSpecifics(string fields)
        {
            Console.Write("What are you looking for in {0}? ", fields);
            string input = Console.ReadLine().Trim();
            return input;
        }

        static void PrintArray(Array recordsArr)
        {
            foreach (var record in recordsArr)
            {
                Console.WriteLine(record.ToString());
            }
        }

    }
}
