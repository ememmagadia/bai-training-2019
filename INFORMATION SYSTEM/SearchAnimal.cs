using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace INFORMATION_SYSTEM
{

    class SearchAnimal
    {
        public Animal[] animals =
     {

            new Animal
            {
                Name="Browny",
                Kind="Dog",
                Gender="Male"
               },
            new Animal
            {
                Name="Mario O",
                Kind="Cat",
                Gender="Female"
            },
            new Animal
            {
                Name="Miya K",
                Kind="Cat",
                Gender="Female"
            },
            new Animal
            {
                Name="King Kong",
                Kind="Monkey",
                Gender="Female"
            },
            new Animal
            {
                Name="Godzilla",
                Kind="Alligator",
                Gender="Male"
            },
            new Animal
            {
                Name="Hachiko",
                Kind="Dog",
                Gender="Male"
            },
            new Animal
            {
                Name="Ron",
                Kind="Dog",
                Gender="Male"
           }


        };
        public void All()
        {
          
            var animalz = from animal in animals
                          select new
                          {
                              animal.Name,
                              animal.Kind,
                              animal.Gender
                          };

            foreach (var i in animalz)
            {
                Console.WriteLine("Name: {0} \nKind: {1} \nGender{2}", i.Name, i.Kind, i.Gender);
            }
        }
        public void byAnimalName(String x)
        {
            Animal a = new Animal();
            var animalz = from animal in animals
                          where animal.Name.Contains(x)
                          select new
                          {
                              animal.Name,
                              animal.Kind,
                              animal.Gender
                          };
            foreach (var i in animalz)
            {
                Console.WriteLine("Name: {0} \nKind: {1} \nGender{2}", i.Name, i.Kind, i.Gender);
            }
        }
        public void byAnimalKind(String x)
        {
            Animal a = new Animal();
            var animalz = from animal in animals
                          where animal.Kind.Contains(x)
                          select new
                          {
                              animal.Name,
                              animal.Kind,
                              animal.Gender
                          };
            foreach (var i in animalz)
            {
                Console.WriteLine("Name: {0} \nKind: {1} \nGender{2}", i.Name, i.Kind, i.Gender);
            }
        }
        public void byAnimalGender(String x)
        {
            Animal a = new Animal();
            var animalz = from animal in animals
                          where animal.Gender.Contains(x)
                          select new
                          {
                              animal.Name,
                              animal.Kind,
                              animal.Gender
                          };
            foreach (var i in animalz)
            {
                Console.WriteLine("Name: {0} \nKind: {1} \nGender{2}", i.Name, i.Kind, i.Gender);
            }
        }
    }
}
