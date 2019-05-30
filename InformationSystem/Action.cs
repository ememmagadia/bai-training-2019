using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationSystem
{
    class Action : IAction
    {

        public void SearchAnimal(string SearchType, string SearchVal)
        {
            SearchType = SearchType.ToLower();
            switch (SearchType)
            {
                case "*":
                    var Result = from animal in Collection.animals
                                     select new
                                     {
                                         animal.Name,
                                         animal.Age,
                                         animal.Gender
                                     };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in Result)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;

                case "name":
                    var NameResult = from animal in Collection.animals
                                     where animal.Name.Contains(SearchVal)
                                     select new
                                     {
                                         animal.Name,
                                         animal.Age,
                                         animal.Gender
                                     };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in NameResult)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;
                case "age":
                    var AgeResult = from animal in Collection.animals
                                    where animal.Age == Convert.ToInt32(SearchVal)
                                    select new
                                    {
                                        animal.Name,
                                        animal.Age,
                                        animal.Gender
                                    };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in AgeResult)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;
                case "gender":
                    var GenderResult = from animal in Collection.animals
                                       where animal.Name.Equals(SearchVal)
                                       select new
                                       {
                                           animal.Name,
                                           animal.Age,
                                           animal.Gender
                                       };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in GenderResult)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;
                default:
                    Console.WriteLine("No result to display");
                    break;
            }
        }


        public void SearchPerson(string SearchType, string SearchVal)
        {
            SearchType = SearchType.ToLower();

            switch (SearchType)
            {
                case "*":
                    var Result = from person in Collection.person
                                     select new
                                     {
                                         person.Name,
                                         person.Age,
                                         person.Gender
                                     };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in Result)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;

                case "name":
                    var NameResult = from person in Collection.person
                                     where person.Name.Contains(SearchVal)
                                     select new
                                     {
                                         person.Name,
                                         person.Age,
                                         person.Gender
                                     };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in NameResult)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;
                case "age":
                    var AgeResult = from person in Collection.person
                                    where person.Age == Convert.ToInt32(SearchVal)
                                    select new
                                    {
                                        person.Name,
                                        person.Age,
                                        person.Gender
                                    };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in AgeResult)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;
                case "gender":
                    var GenderResult = from person in Collection.person
                                       where person.Name.Equals(SearchVal)
                                       select new
                                       {
                                           person.Name,
                                           person.Age,
                                           person.Gender
                                       };

                    //Array arrNameHeight = nameHeight.ToArray();
                    foreach (var val in GenderResult)
                    {
                        Console.WriteLine("{0} | {1} | {2}",
                            val.Name, val.Age, val.Gender);
                    }
                    break;
                default:
                    Console.WriteLine("No result to display");
                    break;
            }
        }
    }
}
