using System;
using System.Linq;

namespace InformationSystems
{
    public class Printer
    {
        AnimalList al = new AnimalList();
        PersonList pl = new PersonList();
        public void PrintAll(string Inp1)
        {
            if (string.Equals(Inp1, "Persons"))
            {
                foreach (var i in pl.PL)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", i.Name, i.Age, i.Gender);
                }
            }
            else if (string.Equals(Inp1, "Animals"))
            {
                foreach (var i in al.AL)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", i.Name, i.Age, i.Gender);
                }
            }
        }
        public void PrintPer(string Inp2, string Inp3)
        {
            switch (Inp2)
            {
                case "Name":
                    var resPN = pl.PL.Where(s => s.Name == Inp3);
                    foreach (var j in resPN)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", j.Name, j.Age, j.Gender);
                    }
                    break;
                case "Age":
                    var resPA = pl.PL.Where(s => Convert.ToString(s.Age) == Inp3);
                    foreach (var j in resPA)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", j.Name, j.Age, j.Gender);
                    }
                    break;
                case "Gender":
                    var resPG = pl.PL.Where(s => s.Gender == Inp3);
                    foreach (var j in resPG)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", j.Name, j.Age, j.Gender);
                    }
                    break;
            }

        }
        public void PrintAni(string Inp2, string Inp3)
        {
            switch (Inp2)
            {
                case "Name":
                    var resAN = al.AL.Where(s => s.Name == Inp3);
                    foreach (var j in resAN)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", j.Name, j.Age, j.Gender);
                    }
                    break;
                case "Age":
                    var resAA = al.AL.Where(s => Convert.ToString(s.Age) == Inp3);
                    foreach (var j in resAA)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", j.Name, j.Age, j.Gender);
                    }
                    break;
                case "Gender":
                    var resAG = al.AL.Where(s => s.Gender == Inp3);
                    foreach (var j in resAG)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Name: {0} - Age: {1} - Gender: {2}", j.Name, j.Age, j.Gender);
                    }
                    break;
            }
        }
    }
}
