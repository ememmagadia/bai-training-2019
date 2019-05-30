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
                Gender = GenderList.Male},
                new Animal{Name = "Cat",
                Age = 7,
                Gender = GenderList.Female},
                new Animal{Name = "Mouse",
                Age = 30,
                Gender = GenderList.Male},
                new Animal{Name = "Goat",
                Age = 12,
                Gender = GenderList.Female},
                new Animal{Name = "Cow",
                Age = 15,
                Gender = GenderList.Male}
            };

        public static Person[] person = new[]
        {
                new Person{Name = "Grace",
                Age = 24,
                Gender = GenderList.Female},
                new Person{Name = "Marc",
                Age = 22,
                Gender = GenderList.Male},
                new Person{Name = "Lex",
                Gender = GenderList.Male},
                new Person{Name = "Dino",
                Age = 29,
                Gender = GenderList.Male},
                new Person{Name = "Charles",
                Age = 25,
                Gender = GenderList.Male},
                new Person{Name = "Arnold",
                Age = 16,
                Gender = GenderList.Male},
                new Person{Name = "Ellah",
                Age = 24,
                Gender = GenderList.Female},
                new Person{Name = "Kyla",
                Age = 26,
                Gender = GenderList.Female},
                new Person{Name = "Melrose",
                Age = 22,
                Gender = GenderList.Female},
                new Person{Name = "Jasper",
                Age = 22,
                Gender = GenderList.Male},
                new Person{Name = "Aaron",
                Age = 22,
                Gender = GenderList.Male}
            };

    }

    public enum GenderList
    {
        Male,
        Female,
        Undefined
    }
}
