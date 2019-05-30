using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public class Person : IProperty
    {
        public Person(string name = "No Name",
            int age = 0,
            GenderList gender = GenderList.Undefined)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public GenderList Gender { get; set; }
    }

}
