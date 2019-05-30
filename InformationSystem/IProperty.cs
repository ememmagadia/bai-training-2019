using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public interface IProperty
    {
        string Name { get; set; }
        int Age { get; set; }
        GenderList Gender { get; set; }


    }
}
