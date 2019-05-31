using System;
using System.Collections.Generic;

namespace InterfacesAndLINQ
{
    class InputAndSearch
    {
        #region ExecSearch
        protected static void ExecSearch(IEnumerable<KantoPokes> result)
        {
            foreach (var i in result)
            {
                Console.WriteLine("Dex no.: {0}\t\tName: {1}\t\t\tType: {2} {3}",
                    i.DexNo, i.Name, i.Type1, i.Type2);
            }
        }
        protected static void ExecSearch(IEnumerable<JohtoPokes> result)
        {
            foreach (var i in result)
            {
                Console.WriteLine("Dex no.: {0}\t\tName: {1}\t\t\tType: {2} {3}",
                    i.DexNo, i.Name, i.Type1, i.Type2);
            }
        }
        #endregion
        protected static void GetAll(Program p, Boolean kanto)
        {
            if (kanto)
            {
                foreach (KantoPokes i in p.box1)
                {
                    Console.WriteLine("Dex no.: {0}\t\tName: {1}\t\t\tType: {2} {3}",
                        i.DexNo, i.Name, i.Type1, i.Type2);
                }
            }
            if (!kanto)
            {
                foreach (JohtoPokes i in p.box2)
                {
                    Console.WriteLine("Dex no.: {0}\t\tName: {1}\t\t\tType: {2} {3}",
                        i.DexNo, i.Name, i.Type1, i.Type2);
                }
            }
        }
        protected static string SearchBy(string region)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Search by:");
                Console.WriteLine("[1] DexNo, [2] Name, [3] Type, [4] List all");
                Console.Write(">>  ");

                input = Console.ReadLine();

                if (input == "1" || input == "2" || input == "3" || input == "4")
                {
                    //Console.WriteLine(region + "" + input);
                    return region + "" + input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.\n\n");
                }

            }
        }
        protected static string ChooseRegion()
        {
            string input;
            while (true)
            {
                Console.WriteLine("Choose a region:");
                Console.WriteLine("[1] Kanto, [2] Johto");
                Console.Write(">>  ");

                input = Console.ReadLine();

                if (input == "1" || input == "2")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.\n\n");
                }

            }
        }
        protected static string GetSearchKeywords()
        {
            Console.Write("Search: ");
            return Console.ReadLine();
        }
    }
}
