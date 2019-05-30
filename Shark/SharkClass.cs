using System;
using System.Collections.Generic;
using System.Text;

namespace Shark
{
    public abstract class Godshark
    {
        public abstract void MakeSound();
    }

    class BabyShark:Godshark
    {
        public override void MakeSound()
        {
            Console.WriteLine("Baby shark says:");
            Console.WriteLine("\t\tDubidubi Dapdap Dubidubi Dapdap");
            Console.WriteLine("\t\tDubidubi Dapdap Dubidubi Dipdip");
            
        }
    }

    class GrandmaShark : Godshark
    {
        public override void MakeSound()
        {
            Console.WriteLine("Grandma shark says:");
            Console.WriteLine("\t\tSabi ng jeep sabi ng jeep sabi ng");
            Console.WriteLine("\t\tBeebeebeebeebeebeebeebeebeebeebeebeep");

        }
    }
    class MommyShark : Godshark
    {
        public override void MakeSound()
        {
            Console.WriteLine("Mommy shark says:");
            Console.WriteLine("\t\tDubidubi Dapdap Dudap Dadap");
            Console.WriteLine("\t\tBeebeep Beebeep beep beep beep beep beep");
            
        }
    }
    class DaddyShark : Godshark
    {
        public override void MakeSound()
        {
            Console.WriteLine("Daddy shark says:");
            Console.WriteLine("\t\tDabadubu Dubudaba Dubudaba Dubudaba");
            Console.WriteLine("\t\tBeep-beep Beebeep Bee-beep beep beep");

        }
    }
    class GrandpaShark : Godshark
    {
        public override void MakeSound()
        {
            Console.WriteLine("Grandpa shark says:");
            Console.WriteLine("\t\tPabapuro Bapbap Purobap Bapbap");
            Console.WriteLine("\t\tBeep BeebeepBeebeepBeebeepBeebeepBeebeepBeebeep Beepbeepbeepbeepbeepbeep");
            Console.WriteLine("\t\tBEEP BEEP BEEP BEEP");
        }
    }
}
