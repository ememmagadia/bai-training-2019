using System;
using System.Linq;
using System.Collections.Generic;
namespace InformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> person = new List<Person>()
            {
                new Person(){PersonID = 1, Name = "LeBron James", Age = 30, Gender="Male"},
                new Person(){PersonID = 2, Name = "Kawhi Leonard", Age = 27, Gender="Male"},
                new Person(){PersonID = 3, Name = "Kobe Bryant", Age = 40, Gender="Male"},
                new Person(){PersonID = 4, Name = "Allen Iverson", Age = 42, Gender="Male"},
                new Person(){PersonID = 5, Name = "Michael Jordan", Age = 50, Gender="Male"},
                new Person(){PersonID = 6, Name = "Liza Soberano", Age = 22, Gender="Female"},
                new Person(){PersonID = 7, Name = "Kathlyn Bernado", Age = 19, Gender="Female"},
                new Person(){PersonID = 8, Name = "Kim Domingo", Age = 23, Gender="Female"},
                new Person(){PersonID = 9, Name = "Mia Khalifa", Age = 26, Gender="Female"},
                new Person(){PersonID = 10, Name = "Maria Ozawa", Age = 38, Gender="Female"}
            };
            IList<Animal> animal = new List<Animal>()
            {
                new Animal(){AnimalID = 1, Name = "Tiger", Age = 11, Gender="Male"},
                new Animal(){AnimalID = 2, Name = "Lion", Age = 15, Gender="Male"},
                new Animal(){AnimalID = 3, Name = "Snake", Age = 12, Gender="Male"},
                new Animal(){AnimalID = 4, Name = "Python", Age = 9, Gender="Male"},
                new Animal(){AnimalID = 5, Name = "Wolf", Age = 8, Gender="Male"},
                new Animal(){AnimalID = 6, Name = "Leopard", Age = 7, Gender="Female"},
                new Animal(){AnimalID = 7, Name = "Giraffe", Age = 6, Gender="Female"},
                new Animal(){AnimalID = 8, Name = "Eagle", Age = 4, Gender="Female"},
                new Animal(){AnimalID = 9, Name = "Dog", Age = 4, Gender="Female"},
                new Animal(){AnimalID = 10, Name = "Cat", Age = 1, Gender="Female"}
            };
            string Select, WhatYouWantTodo, SearchOption, Search;
            int SearchAge;
            Console.WriteLine("Select a Person or Animal?");
            ClassInformation classInfo = new ClassInformation();
            Select = classInfo.ValidateSelect("");
            Console.WriteLine("What do you want to do? Select All or Search?");
            WhatYouWantTodo = classInfo.ValidateWhatToSearch("");
            if (string.Equals(WhatYouWantTodo, "search", StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(Select, "person", StringComparison.OrdinalIgnoreCase))
                {
                   
                    SearchOption = classInfo.ValidateSelectOption("");

                    if (string.Equals(SearchOption, "name", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.PersonNameSearch();
                    }
                    else if (string.Equals(SearchOption, "age", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.PersonAgeSearch();

                    }
                    else if (string.Equals(SearchOption, "gender", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.PersonGenderSearch();
                    }
                    else
                    {
                        Console.WriteLine("Please Try Again");
                    }

                }
                else
                {
                  
                    SearchOption = classInfo.ValidateSelectOption("");
                    if (string.Equals(SearchOption, "name", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.AnimalNameSearch();
                    }
                    else if (string.Equals(SearchOption, "age", StringComparison.OrdinalIgnoreCase))
                    {

                        classInfo.AnimalAgeSearch();

                    }
                    else if (string.Equals(SearchOption, "gender", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.AnimalGenderSearch();
                    }
                    else
                    {
                        Console.WriteLine("Please Try Again");
                    }

                }
            }
            else
            {
                if (string.Equals(Select, "person", StringComparison.OrdinalIgnoreCase))
                {
                    //Multiple select operator
                    classInfo.PersonInfoAll();
                }
                else
                {
                    classInfo.AnimalInfoAll();
                }
            }


        }
    }
}
