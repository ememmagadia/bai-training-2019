using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationSystem
{
    class Person : IProperty
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }

        public string SearchInput { get; set; }

        public List<Person> people = new List<Person>();

        public void LoadPersonList()
        {
            people.Add(new Person { Id = 1, Name = "Jelma", Age = 13, Gender = "Female" });
            people.Add(new Person { Id = 2, Name = "Marc", Age = 35, Gender = "Male" });
            people.Add(new Person { Id = 3, Name = "Lex", Age = 23, Gender = "Male" });
            people.Add(new Person { Id = 4, Name = "Dino", Age = 29, Gender = "Male" });
            people.Add(new Person { Id = 5, Name = "Charles", Age = 22, Gender = "Male" });
            people.Add(new Person { Id = 6, Name = "Arnold", Age = 25, Gender = "Male" });
            people.Add(new Person { Id = 7, Name = "Ellah", Age = 24, Gender = "Female" });
            people.Add(new Person { Id = 8, Name = "Kyla", Age = 23, Gender = "Female" });
            people.Add(new Person { Id = 9, Name = "Melrose", Age = 18, Gender = "Female" });
            people.Add(new Person { Id = 10, Name = "Jasper", Age = 23, Gender = "Male" });
            people.Add(new Person { Id = 11, Name = "Aaron", Age = 20, Gender = "Male" });
        }

        public void Search()
        {
            int age = 0;
            bool isInt = Int32.TryParse(SearchInput, out age);

            var search = from p in people
                         where p.Name.ToLower() == SearchInput.ToLower() || p.Gender == SearchInput.ToLower() || p.Age == age
                         select p;

            Console.WriteLine("List of person with the same value you entered: ");
            foreach (var sa in search)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Gender: {2}", sa.Name, sa.Age, sa.Gender);
            }
        }
        public void GetAll()
        {

            var queryGetAll = from label in people select label;
            Console.WriteLine("List of {0}:", people);

            foreach (var q in queryGetAll)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Gender: {2}", q.Name, q.Age, q.Gender);
            }
        }
        

    }
}
