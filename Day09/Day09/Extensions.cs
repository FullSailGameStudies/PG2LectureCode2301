using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public static class Extensions
    {
        public static decimal Sum(this Calculator t1000, decimal d1, decimal d2)
        {
            return d1 + d2;
        }

        public static ConsoleColor GetColor(this decimal number)
        {
            if (number < 0) return ConsoleColor.Red;

            return ConsoleColor.Green;
        }
    }
}
