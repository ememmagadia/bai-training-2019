using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IMove
    {
        void Run();

        void Walk();

        string Shout(string shout);
    }
    interface IPlay
    {
        void Basketball();

        int Points(int HowMuch);
    }
    interface ICook
    {
        void Cook();

        string Recipe(string recipe);

    }
}
