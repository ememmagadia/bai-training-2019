using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    interface IAction
    {
        void SearchAnimal(string SearchType, string SearchVal);
        void SearchPerson(string SearchType, string SearchVal);
    }
}
