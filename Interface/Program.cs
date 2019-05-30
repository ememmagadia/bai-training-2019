using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 40;
            string shout = "GOOO!";
            Human human = new Human
            {
                Name = "Marc Kenneth Lomio",
                Running = "I Run faster",
                Walking = "Walking"
            };

            human.Basketball();
            human.Points(points);
            human.Run();
            human.Shout(shout);


        }
    }
}
