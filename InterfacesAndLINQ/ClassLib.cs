using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndLINQ
{
    class KantoPokes : IPokemonData
    {
        public string Name { get; set; }

        public string DexNo { get; set; }

        public string Type1 { get; set; }

        public string Type2 { get; set; }

        public KantoPokes(string name = "?", string dex = "000", string type1 = null, string type2 = null)
        {
            Name = name;
            DexNo = dex;
            Type1 = type1;
            Type2 = type2;
        }
    }

    class JohtoPokes : IPokemonData
    {
        public string Name { get; set; }

        public string DexNo { get; set; }

        public string Type1 { get; set; }

        public string Type2 { get; set; }

        public JohtoPokes(string name = "?", string dex = "000", string type1 = null, string type2 = null)
        {
            Name = name;
            DexNo = dex;
            Type1 = type1;
            Type2 = type2;
        }
    }
}
