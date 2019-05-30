using System;

namespace Shark
{
    class Program
    {
        static void Main(string[] args)
        {
            BabyShark bbysh = new BabyShark();
            MommyShark mmysh = new MommyShark();
            DaddyShark ddysh = new DaddyShark();
            GrandmaShark grmsh = new GrandmaShark();
            GrandpaShark grpsh = new GrandpaShark();

            bbysh.MakeSound();
            mmysh.MakeSound();
            ddysh.MakeSound();
            grmsh.MakeSound();
            grpsh.MakeSound();

        }
    }
}
