using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{

    struct ColorStruct
    {
        //color has red, green, blue, alpha

    }

    public class GameObject
    {
        #region Fields
        private int _x, _y;

        private static int _numberOfObjects = 0;
        #endregion

        #region Properties
        //AUTO property: the compiler provides the backing field. no code in the get/set.
        public ConsoleColor Color { get; private set; } = ConsoleColor.Green;

        public int Y
        {
            get { return _y; }
            set { 
                if(value >= 0 && value < Console.WindowHeight)
                    _y = value; 
            }
        }


        //FULL property: backing field + property
        public int X  //_x is the backing field
        {
            //accessor
            //same as...
            //public int GetX() {return _x;}
            get { return _x; }

            //mutator
            //same as...
            //public void SetX(int value) { _x = value; }
            protected set { 
                if(value >= 0 && value < Console.WindowWidth)
                    _x = value; 
            }
        }
        #endregion

        #region Constructors (ctor)
        //the compiler will give you a default ctor IF you don't provide any ctor
        //public GameObject() //default ctor (no parameters)
        //{

        //}
        public GameObject(int x, int y, ConsoleColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        #endregion

        public virtual void Draw()//hidden parameter called 'GameObject this'
        {
            Console.SetCursorPosition(_x, _y);
            Console.BackgroundColor = Color;
            Console.WriteLine(" ");
        }

        public static void DebugReport()//there is NO 'this'
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"# of objects: {_numberOfObjects}");
        }
    }
}
