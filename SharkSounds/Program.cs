using System;

namespace SharkSounds
{
    public interface IMakeSound
    {
        void MakeSound();
    }
    public class Shark: IMakeSound
    {
        public string Name;
        public string Sound;
        public void MakeSound()
        {
            Console.WriteLine("{0} {1}", Name, Sound);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - Shark Sounds - ");
            Shark BabyShark = new Shark
            {
                Name = "Baby Shark",
                Sound = "dooo dooo dooooo"
            };
            Shark MommyShark = new Shark
            {
                Name = "Mommy Shark",
                Sound = "doo doo doo doo"
            };
            Shark DaddyShark = new Shark
            {
                Name = "Daddy Shark",
                Sound = "doo doo doo doo"
            };

            BabyShark.MakeSound();
            MommyShark.MakeSound();
            DaddyShark.MakeSound();
        }
    }
}
