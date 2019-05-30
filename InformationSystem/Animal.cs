using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public class Animal : IProperty
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderList Gender { get; set; }
    }
}
