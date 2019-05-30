using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystems
{
    public class Animal
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
    public class AnimalList
    {
        public List<Animal> AL { get; set; }
        public AnimalList()
        {
            this.AL = new List<Animal>()
            {
                new Animal(){Name="John Wick",Age=15,Gender="F"},
                new Animal(){Name="Ghost",Age=20,Gender="F"},
                new Animal(){Name="Nymeria",Age=20,Gender="F"},
                new Animal(){Name="Red XIII",Age=15,Gender="M"},
                new Animal(){Name="Beethoven",Age=15,Gender="M"},
                new Animal(){Name="Air Bud",Age=37,Gender="M"},
                new Animal(){Name="Bolt",Age=37,Gender="M"},
                new Animal(){Name="Kuma",Age=20,Gender="M"},
                new Animal(){Name="Watchdogman",Age=30,Gender="M"},
                new Animal(){Name="Pablo",Age=30,Gender="M"},
                new Animal(){Name="Nico",Age=15,Gender="F"},
                new Animal(){Name="DMX",Age=20,Gender="M"}
            };
        }
        
    }
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

    }
    public class PersonList
    {
        public List<Person> PL { get; set; }
        public PersonList()
        {
            this.PL = new List<Person>()
            {
                new Person(){Name="Lex",Age=22,Gender="M"},
                new Person(){Name="Grace",Age=20,Gender="F"},
                new Person(){Name="Aaron",Age=22,Gender="M"},
                new Person(){Name="Jasper",Age=23,Gender="M"},
                new Person(){Name="Rose",Age=20,Gender="F"},
                new Person(){Name="Mark",Age=21,Gender="M"},
                new Person(){Name="Dino",Age=22,Gender="M"},
                new Person(){Name="Arnold",Age=23,Gender="M"},
                new Person(){Name="Charles",Age=20,Gender="M"},
                new Person(){Name="Ella",Age=21,Gender="F"},
                new Person(){Name="Kyla",Age=23,Gender="F"},
                new Person(){Name="Aljur",Age=23,Gender="M"}
            };
        }
    }
}
