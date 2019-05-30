using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace INFORMATION_SYSTEM
{
    class SearchPerson
    {
        public Person[] persons =
        {
            new Person
            {
                Name="Sadao Maou",
                Age="99",
                Gender="Male"
               },
            new Person
            {
                Name="Emi Yusa",
                Age="21",
                Gender="Female"
            },
            new Person
            {
                Name="Chiho Sasaki",
                Age="19",
                Gender="Female"
            },
            new Person
            {
                Name="Miki Shiba",
                Age="47",
                Gender="Female"
            },
            new Person
            {
                Name="Rika Suzuki",
                Age="22",
                Gender="Female"
            },
            new Person
            {
                Name="Sadao Maou",
                Age="19",
                Gender="Male"
            },
            new Person
            {
                Name="Shiro Alciel",
                Age="55",
                Gender="Male"
           }

        };
        public void All()
        {

            var personz = from person in persons
                          select new
                          {
                              person.Name,
                              person.Age,
                              person.Gender
                          };

            foreach (var i in personz)
            {
                Console.WriteLine("Name: {0} \nAge: {1} \nGender: {2}", i.Name, i.Age, i.Gender);
            }
            
        }
        
        public void byPersonName(String x)
        {

            var personz = from person in persons
                          where person.Name.Contains(x)
                          select new
                          {
                              person.Name,
                              person.Age,
                              person.Gender
                          };

            foreach (var i in personz)
            {
                Console.WriteLine("Name: {0} \nAge: {1} \nGender{2}: ", i.Name, i.Age, i.Gender);
            }
            
        }
            public void byPersonAge(String x)
            {

                var personz = from person in persons
                              where person.Age.Equals(x)
                              select new
                              {
                                  person.Name,
                                  person.Age,
                                  person.Gender
                              };

                foreach (var i in personz)
                {
                    Console.WriteLine("Name: {0} \nAge: {1} \nGender: {2}", i.Name, i.Age, i.Gender);
                }
            }
        public void byPersonGender(String x)
        {

            var personz = from person in persons
                          where person.Gender.Contains(x)
                          select new
                          {
                              person.Name,
                              person.Age,
                              person.Gender
                          };

            foreach (var i in personz)
            {
                Console.WriteLine("Name: {0} \nAge: {1} \nGender: {2}", i.Name, i.Age, i.Gender);
            }
        }

    }
    
}
