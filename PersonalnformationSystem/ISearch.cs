using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalnformationSystem
{
    interface ISearch
    {
        void SearchByName(string Name, string Category);
        void SearchByAge(int Age, string Category);
        void SearchByGender(string Gender, string Category);
    }
}
