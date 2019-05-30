using System;

namespace CShark
{
    class Sharks
    {
        public string Name;
        public string Sound;

        public Sharks (string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public void makeSound()
        {
            Console.WriteLine("{0} says {1}", Name, Sound);
        }
    }
}
