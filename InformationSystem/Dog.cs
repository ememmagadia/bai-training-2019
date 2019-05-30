using System;
using System.Linq;

namespace InformationSystem
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Array QueryAll(Dog[] dogs)
        {
            var dogQuery = from dog in dogs select new { dog.Name, dog.Age, dog.Breed };
            return dogQuery.ToArray();
        }

        public Array QueryByName(Dog[] dogs, string keyword)
        {
            var dogQuery = from dog in dogs
                           where String.Equals(dog.Name, keyword, StringComparison.CurrentCultureIgnoreCase)
                           select new { dog.Name, dog.Age, dog.Breed };
            return dogQuery.ToArray();
        }

        public Array QueryByAge(Dog[] dogs, int keyword)
        {
            var dogQuery = from dog in dogs
                           where dog.Age == keyword
                           select new { dog.Name, dog.Age, dog.Breed };
            return dogQuery.ToArray();
        }

        public Array QueryByBreed(Dog[] dogs, string keyword)
        {
            var dogQuery = from dog in dogs
                           where String.Equals(dog.Breed, keyword, StringComparison.CurrentCultureIgnoreCase)
                           select new { dog.Name, dog.Age, dog.Breed };
            return dogQuery.ToArray();
        }
    }
}
