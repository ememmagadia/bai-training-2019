using System;
using System.Linq;
using System.Collections.Generic;
namespace InformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string Select, WhatYouWantTodo, SearchOption, Search;
            int SearchAge;
            Console.WriteLine("Select a Person or Animal?");
            ClassInformation classInfo = new ClassInformation();
            Select = classInfo.ValidateSelect("");
            Console.WriteLine("What do you want to do? Select All or Search?");
            WhatYouWantTodo = classInfo.ValidateWhatToSearch("");
            if (string.Equals(WhatYouWantTodo, "search", StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(Select, "person", StringComparison.OrdinalIgnoreCase))
                {
                   
                    SearchOption = classInfo.ValidateSelectOption("");

                    if (string.Equals(SearchOption, "name", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.PersonNameSearch();
                    }
                    else if (string.Equals(SearchOption, "age", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.PersonAgeSearch();

                    }
                    else if (string.Equals(SearchOption, "gender", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.PersonGenderSearch();
                    }
                    else
                    {
                        Console.WriteLine("Please Try Again");
                    }

                }
                else
                {
                  
                    SearchOption = classInfo.ValidateSelectOption("");
                    if (string.Equals(SearchOption, "name", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.AnimalNameSearch();
                    }
                    else if (string.Equals(SearchOption, "age", StringComparison.OrdinalIgnoreCase))
                    {

                        classInfo.AnimalAgeSearch();

                    }
                    else if (string.Equals(SearchOption, "gender", StringComparison.OrdinalIgnoreCase))
                    {
                        classInfo.AnimalGenderSearch();
                    }
                    else
                    {
                        Console.WriteLine("Please Try Again");
                    }

                }
            }
            else
            {
                if (string.Equals(Select, "person", StringComparison.OrdinalIgnoreCase))
                {
                    //Multiple select operator
                    classInfo.PersonInfoAll();
                }
                else
                {
                    classInfo.AnimalInfoAll();
                }
            }


        }
    }
}
