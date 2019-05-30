using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesAndLINQ
{
    class Program
    {
        IList<KantoPokes> box1 = new List<KantoPokes>()
            {
                new KantoPokes{Name="Bulbasaur",
                DexNo="001", Type1 = "Grass", Type2 ="Poison"},
                new KantoPokes{Name="Onix",
                DexNo="95", Type1 = "Rock", Type2 ="Ground"},
                new KantoPokes{Name="Exeggutor",
                DexNo="103", Type1 = "Grass", Type2 ="Psychic"},
                new KantoPokes{Name="Porygon",
                DexNo="137", Type1 = "Normal"},
                new KantoPokes{Name="Seadra",
                DexNo="117", Type1 = "Water"},
                new KantoPokes{Name="Weezing",
                DexNo="110", Type1 = "Poison"}
            };

        IList<JohtoPokes> box2 = new List<JohtoPokes>()
            {
                new JohtoPokes{Name="Scizor",
                DexNo="212", Type1 = "Bug", Type2 ="Steel"},
                new JohtoPokes{Name="Sneasel",
                DexNo="215", Type1 = "Dark", Type2 ="Ice"},
                new JohtoPokes{Name="Espeon",
                DexNo="196", Type1 = "Psychic"},
                new JohtoPokes{Name="Quilava",
                DexNo="156", Type1 = "Fire"},
                new JohtoPokes{Name="Noctowl",
                DexNo="117", Type1 = "Normal", Type2 = "Flying"},
                new JohtoPokes{Name="Ampharos",
                DexNo="181", Type1 = "Electric"}
            };

        static void Main(string[] args)
        {
            Program p = new Program();

            string Region = ChooseRegion();
            //if (Region == "1")
            //{

                SearchBy(ChooseRegion());
            //}
            //else
            //{
            //    Console.WriteLine("2");
            //}

            //foreach (KantoPokes i in p.box1)
            //{
            //    Console.WriteLine("Dex no.: {0}\t\tName: {1}\t\t\tType: {2} {3}",
            //        i.DexNo, i.Name, i.Type1, i.Type2);
            //}

            //foreach (JohtoPokes i in box2)
            //{
            //    Console.WriteLine("Dex no.: {0}\t\tName: {1}\t\t\tType: {2} {3}",
            //        i.DexNo, i.Name, i.Type1, i.Type2);
            //}
        }

        static void GetAll()
        {

        }

        static string SearchBy(string region)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Search by:");
                Console.WriteLine("[1] DexNo, [2] Name, [3] Name, [4] List all");
                Console.Write(">>");

                input = Console.ReadLine();

                if (input == "1" || input == "2" || input == "3" || input == "4")
                {
                    Console.WriteLine(region + "" + input);
                    return region + "" + input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.\n\n");
                }

            }
        }
        static string ChooseRegion()
        {
            string input;
            while (true)
            {
                Console.WriteLine("Choose a region:");
                Console.WriteLine("[1] Kanto, [2] Johto");
                Console.Write(">>");

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
    }
}
