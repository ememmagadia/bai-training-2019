using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationSystem
{
   public class ClassInformation : IPerson , IAnimal
    {
        public IList<Person> person = new List<Person>()
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
      public  IList<Animal> animal = new List<Animal>()
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

        public string select;
        public string search;
        public int searchAge;
        public string ValidateSelect(string validate)
        {
            while (true)
            {
                select = Console.ReadLine();
                if (string.Equals(select, "Person", StringComparison.OrdinalIgnoreCase) || string.Equals(select, "Animal", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Try Again");
                }
            }
            return select;
        }
        public string ValidateWhatToSearch(string validate)
        {
            while (true)
            {
                select = Console.ReadLine();
                if (string.Equals(select, "All", StringComparison.OrdinalIgnoreCase) || string.Equals(select, "Search", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Try Again");
                }
            }
            return select;
        }
        public string ValidateSelectOption(string validate)
        {
            Console.WriteLine("Select what do you want to search in Animal");
            Console.WriteLine("1. Name, 2. Age, 3. Gender");

            while (true)
            {
                select = Console.ReadLine();
                if (string.Equals(select, "name", StringComparison.OrdinalIgnoreCase) || string.Equals(select, "age", StringComparison.OrdinalIgnoreCase) || string.Equals(select, "gender", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Try Again");
                }
            }
            return select;

        }

        public void  PersonNameSearch()
        {
            Console.WriteLine("Search Name");
            search = Console.ReadLine();
            var Searched = person.Where(s => s.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                              .Select(s => s);
            Searched.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));
        }
        public void PersonAgeSearch()
        {
            Console.WriteLine("Search Age");
            searchAge = Int32.Parse(Console.ReadLine());
            var Searched = person.Where(s => s.Age == searchAge)
                             .Select(s => s);
            Searched.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));

        }

        public void PersonGenderSearch()
        {
            Console.WriteLine("Search Gender");
            search = Console.ReadLine();
            var Searched = person.Where(s => s.Gender.Equals(search, StringComparison.OrdinalIgnoreCase))
                              .Select(s => s);
            Searched.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));
        }
        public void PersonInfoAll()
        {
            var personNames = person.Select(s => s);

            personNames.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));

        }

        public void AnimalNameSearch()
        {
            Console.WriteLine("Search Name");
            search = Console.ReadLine();
            var Searched = animal.Where(s => s.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                              .Select(s => s);
            Searched.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));
        }

        public void AnimalAgeSearch()
        {
            Console.WriteLine("Search Age");
            searchAge = Int32.Parse(Console.ReadLine());
            var Searched = animal.Where(s => s.Age == searchAge)
                             .Select(s => s);
            Searched.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));
        }

        public void AnimalGenderSearch()
        {
            Console.WriteLine("Search Gender");
            search = Console.ReadLine();
            var Searched = animal.Where(s => s.Gender.Equals(search, StringComparison.OrdinalIgnoreCase))
                              .Select(s => s);
            Searched.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));
        }
        public void AnimalInfoAll()
        {
            var animalNames = animal.Select(s => s);

            animalNames.ToList().ForEach(s => Console.WriteLine("Name: {0} Age: {1} Gender: {2}", s.Name, s.Age, s.Gender));
        }
    }
}
