using InformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoSystem
{
    class Animal : IProperty
    {
        private string name;
        private string gender;
        private int age;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }

        public string SearchInput { get; set; }

        public List<Animal> animals = new List<Animal>();
        public void LoadAnimalList()
        {
            animals.Add(new Animal { Id = 1, Name = "Dog", Age = 13, Gender = "Female" });
            animals.Add(new Animal { Id = 2, Name = "Cat", Age = 5, Gender = "Male" });
            animals.Add(new Animal { Id = 3, Name = "Rabbit", Age = 3, Gender = "Male" });
            animals.Add(new Animal { Id = 4, Name = "Hamster", Age = 2, Gender = "Male" });
        }
        public void Search()
        {

            int age = 0;
            bool isInt = Int32.TryParse(SearchInput, out age);

            var search = from a in animals
                         where a.Name == SearchInput.ToLower() || a.Gender == SearchInput.ToLower() || a.Age == age
                         select a;

            Console.WriteLine("List of person with the same value you entered: ");
            foreach (var sa in search)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Gender: {2}", sa.Name, sa.Age, sa.Gender);
            }
        }
        public void GetAll()
        {
            var queryGetAll = from animal in animals select animal;
            Console.WriteLine("List of animal:");

            foreach (var q in queryGetAll)
            {
                Console.WriteLine("Name: {0}, Age: {1},", q.Name, q.Age);
            }
        }

        
    }
}
