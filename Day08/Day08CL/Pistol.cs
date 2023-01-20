using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public class Pistol : Weapon
    {
        public int Rounds { get; set; }
        public int MagCapacity { get; set; }

        public Pistol(int rounds, int magCap, int range, int damage) : base(range, damage)
        {
            Rounds = rounds;
            MagCapacity = magCap;
        }

        public override void ShowMe()
        {
            base.ShowMe();//extend the base
            Console.WriteLine($"\tRounds: {Rounds}\tMag Capacity: {MagCapacity}");
        }
    }
}
