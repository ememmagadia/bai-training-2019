using System;

namespace SharkSounds
{
      abstract class SharkSound
    {
        public abstract String sound();
    }
    class Shark : SharkSound
    {
        private string Sharksound;

        public Shark(string s)
        {
            Sharksound = s;
        }
        public override string sound()
        {
            return (Sharksound);
        }
    } 
    class Program
    {
        
        static void Main(string[] args)
        {
           Console.WriteLine("SharkSound Using Abstract");
           String[] listOfShark = { "Daddy Shark", "Mommy Shark", "GrandPa Shark", "GrandMa Shark", "Baby Shark" };
           for(int i = 0; i<listOfShark.Length; i++)
            {
                Console.WriteLine("Enter The Sound Of {0}",listOfShark[i]);
                String inputSound = Console.ReadLine();
                Shark shark = new Shark(inputSound);
                String result = shark.sound();
                Console.WriteLine("{0} Sound {1}",listOfShark[i],result);
            }

            //Console.WriteLine("SharkSound Using Polymorphism");
            //for (int i = 0; i < listOfShark.Length; i++)
            //{
            //    Console.WriteLine("Enter The Sound Of " + listOfShark[i]);
            //    String inputSound = Console.ReadLine();
            //    Sound sound = new Sound();
            //    Console.WriteLine(listOfShark[i] + "Sound " + sound.makeSound(inputSound));
            //}
        }
    }
}
