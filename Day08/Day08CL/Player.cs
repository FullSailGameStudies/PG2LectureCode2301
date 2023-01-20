using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    //Derived class (Specialized)
    public class Player : GameObject
    {
        public char Symbol { get; set; }
        //Player can move
        public Player(char symbol, int x, int y, ConsoleColor color) 
            : base(x,y,color)
        {
            Symbol= symbol;
        }

        public void Update()
        {
            X++;
        }
    }
}
