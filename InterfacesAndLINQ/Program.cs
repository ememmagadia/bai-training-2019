using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesAndLINQ
{
    class Program : InputAndSearch
    {
        public IList<KantoPokes> box1 = new List<KantoPokes>()
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

        public IList<JohtoPokes> box2 = new List<JohtoPokes>()
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
                DexNo="181", Type1 = "Electric"},
                new JohtoPokes{Name="Ariados",
                DexNo="168", Type1 = "Bug", Type2 = "Poison"},
                new JohtoPokes{Name="Pichu",
                DexNo="172", Type1 = "Electric"},
                new JohtoPokes{Name="Xatu",
                DexNo="178", Type1 = "Psychic", Type2 = "Flying"}
            };

        static void Main(string[] args)
        {
            Program p = new Program();

            string Region = ChooseRegion();

            string Search = SearchBy(Region);

            if (Search == "14")
            {
                GetAll(p, true);
            }
            if (Search == "24")
            {
                GetAll(p, false);
            }
            else
            {
                string Keywords = GetSearchKeywords();

                if (Search == "11")
                {
                    IEnumerable<KantoPokes> result = p.box1.Where(a => a.DexNo.Contains(Keywords));
                    ExecSearch(result);
                }
                if (Search == "12")
                {
                    IEnumerable<KantoPokes> result = p.box1.Where(a => a.Name.Contains(Keywords));
                    ExecSearch(result);
                }
                if (Search == "13")
                {
                    IEnumerable<KantoPokes> result = p.box1.Where(a => a.Type1.Contains(Keywords));
                    ExecSearch(result);
                }
                if (Search == "21")
                {
                    IEnumerable<JohtoPokes> result = p.box2.Where(a => a.DexNo.Contains(Keywords));
                    ExecSearch(result);
                }
                if (Search == "22")
                {
                    IEnumerable<JohtoPokes> result = p.box2.Where(a => a.Name.Contains(Keywords));
                    ExecSearch(result);
                }
                if (Search == "23")
                {
                    IEnumerable<JohtoPokes> result = p.box2.Where(a => a.Type1.Contains(Keywords));
                    ExecSearch(result);
                }
            }
        }

        static string Queries(Program p)
        {
            foreach (KantoPokes i in p.box1)
            {
                Console.WriteLine("Dex no.: {0}\t\tName: {1}\t\t\tType: {2} {3}",
                    i.DexNo, i.Name, i.Type1, i.Type2);
            }
            return "1";
        }

    }
}
