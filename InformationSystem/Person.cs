using System;
using System.Linq;

namespace InformationSystem
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Array QueryAll(Person[] people)
        {
            var personQuery = from person in people select new { person.Name, person.Age, person.Gender };
            return personQuery.ToArray();
        }

        public Array QueryByName(Person[] people, string keyword)
        {
            var personQuery = from person in people
                              where String.Equals(person.Name, keyword, StringComparison.CurrentCultureIgnoreCase)
                              select new { person.Name, person.Age, person.Gender };
            return personQuery.ToArray();
        }

        public Array QueryByAge(Person[] people, int keyword)
        {
            var personQuery = from person in people
                              where person.Age == keyword
                              select new { person.Name, person.Age, person.Gender };
            return personQuery.ToArray();
        }

        public Array QueryByGender(Person[] people, string keyword)
        {
            var personQuery = from person in people
                              where String.Equals(person.Gender, keyword, StringComparison.CurrentCultureIgnoreCase)
                              select new { person.Name, person.Age, person.Gender };
            return personQuery.ToArray();
        }
    }
}
