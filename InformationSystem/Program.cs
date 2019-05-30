using System;

namespace InformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = new Action();
            string type = "";
            string by = "";
            while (true)
            {
                Console.Write("What do you want to search, Person or Animals: ");
                type = (Console.ReadLine()).ToLower();
                if (type == "person" || type == "animals")
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Enter valid category: ");
                    
                }
            }
            while (true)
            {
                Console.Write("What do you want to search by:\nName, Age, Gender or * to display all : ");
                by = (Console.ReadLine()).ToLower();
                if (by == "name" || by == "age"|| by == "gender")
                {
                    Console.Write("Enter search keyword: ");
                    string keyWord = Console.ReadLine();
                    switch (type)
                    {
                        case "animals":
                            action.SearchAnimal(by, keyWord);
                            break;
                        case "person":
                            action.SearchPerson(by, keyWord);
                            break;
                        default:
                            break;
                    }

                    break;
                }
                else if (by == "*")
                {
                    switch (type)
                    {
                        case "animals":
                            action.SearchAnimal(by, "");
                            break;
                        case "person":
                            action.SearchPerson(by, "");
                            break;
                        default:
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid property: ");
                }
            }



        }
    }
}
