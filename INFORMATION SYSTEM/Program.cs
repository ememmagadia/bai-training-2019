using System;
using System.Linq;

namespace INFORMATION_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Information System \n\n");
            Console.WriteLine(" What do you want Search\n[1]Person\n[2]Animal");
            String PoA = Console.ReadLine();
            if (PoA.Equals("1"))
            {
                SearchPerson SP = new SearchPerson();
                Console.WriteLine("Please Select category to search for\n[1]All\n[2]Name\n[3]Age\n[4]Gender");
                String category = Console.ReadLine();
                if (category.Equals("1"))
                {
                    SP.All();
                }
                else if (category.Equals("2"))
                {
                    Console.WriteLine("What Name are you looking for?\n");
                    String x = Console.ReadLine();
                    SP.byPersonName(x);
                }
                else if (category.Equals("1"))
                {
                    Console.WriteLine("What age are you looking for?\n");
                    String x = Console.ReadLine();
                    SP.byPersonAge(x);
                }
                else if (category.Equals("1"))
                {
                    Console.WriteLine("What age are you looking for?\n");
                    String x = Console.ReadLine();
                    SP.byPersonGender(x);
                }
            }
            if (PoA.Equals("2"))
            {
                SearchAnimal SA = new SearchAnimal();
                SearchPerson SP = new SearchPerson();
                Console.WriteLine("Please Select category to search for\n[1]All\n[2]Name\n[3]Kind\n[4]Gender");
                String category = Console.ReadLine();
                if (category.Equals("1"))
                {
                    SA.All();
                }
                else if (category.Equals("2"))
                {
                    Console.WriteLine("What Name are you looking for?\n");
                    String x = Console.ReadLine();
                    SA.byAnimalName(x);
                }
                else if (category.Equals("1"))
                {
                    Console.WriteLine("What age are you looking for?\n");
                    String x = Console.ReadLine();
                    SA.byAnimalKind(x);
                }
                else if (category.Equals("1"))
                {
                    Console.WriteLine("What age are you looking for?\n");
                    String x = Console.ReadLine();
                    SA.byAnimalGender(x);
                }
            }

        }
    }

}
