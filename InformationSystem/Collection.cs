using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public static class Collection
    {
        public static Animal[] animals = new[]
     {
                new Animal{Name = "Dog",
                Age = 25,
                Gender = "Male"},
                new Animal{Name = "Cat",
                Age = 7,
                Gender = "Female"},
                new Animal{Name = "Mouse",
                Age = 30,
                Gender = "Male"},
                new Animal{Name = "Goat",
                Age = 12,
                Gender = "Female"},
                new Animal{Name = "Cow",
                Age = 15,
                Gender = "Male"},
            };

        public static Person[] person = new[]
        {
                new Person{Name = "Grace",
                Age = 24,
                Gender = "Female"},
                new Person{Name = "Marc",
                Age = 22,
                Gender = "Male"},
                new Person{Name = "Lex",
                Age = 24,
                Gender = "Male"},
                new Person{Name = "Dino",
                Age = 29,
                Gender = "Male"},
                new Person{Name = "Charles",
                Age = 25,
                Gender = "Male"},
                new Person{Name = "Arnold",
                Age = 16,
                Gender = "Male"},
                new Person{Name = "Ellah",
                Age = 24,
                Gender = "Female"},
                new Person{Name = "Kyla",
                Age = 26,
                Gender = "Female"},
                new Person{Name = "Melrose",
                Age = 22,
                Gender = "Female"},
                new Person{Name = "Jasper",
                Age = 22,
                Gender = "Male"},
                new Person{Name = "Aaron",
                Age = 22,
                Gender = "Male"},
            };

    }

    public enum GenderList
    {
        Male,
        Female,
        Undefined
    }
}
