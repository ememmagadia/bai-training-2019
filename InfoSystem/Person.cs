using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    class Person : IProperty
    {

        private string name;
        private string gender;
        private int age;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void PersonList()
        {
            Person[] people = new[] {
                new Person
                {
                    Id = 1,
                    Name = "Ethos",
                    Age = 19,
                    Gender = "m"
                },
                new Person
                {
                    Id = 2,
                    Name = "Alys",
                    Age = 25,
                    Gender = "f"
                },
                new Person
                {
                    Id = 3,
                    Name = "Zari",
                    Age = 11,
                    Gender = "f"
                }
            };
        }
        public void GetAll()
        {
            throw new NotImplementedException();
        }


    }
}
