using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class GameObject
    {
        #region Fields
        private int _x, _y;
        #endregion

        #region Properties
        //AUTO property: the compiler provides the backing field. no code in the get/set.
        public ConsoleColor Color { get; private set; }

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
            set { 
                if(value >= 0 && value < Console.WindowWidth)
                    _x = value; 
            }
        }
        #endregion

        void Draw()
        {
            Console.SetCursorPosition(_x, _y);
        }
    }
}
