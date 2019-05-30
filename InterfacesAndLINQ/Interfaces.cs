using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndLINQ
{
    interface IPokemonData
    {
        string Name { get; set; }
        string DexNo { get; set; }
        string Type1 { get; set; }
        string Type2 { get; set; }
    }

}
