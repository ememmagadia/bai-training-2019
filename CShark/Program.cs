using System;

namespace CShark
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Sharks sharks = new Sharks("Baby Shark", "Daadaadaadaadaa");
            Sharks Mshark = sharks;
            Sharks Dshark = sharks;

            Mshark.Name = "Mama Shark";
            Mshark.Sound = "Diidiidiidiiidii";

            Dshark.Name = "Dada Shark";
            Dshark.Sound = "Diidiidiidiiidii";

            sharks.makeSound();
            Mshark.makeSound();
            Dshark.makeSound();


        }
    }
}
