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

        void Draw()
        {
            Console.SetCursorPosition(_x, _y);
        }
    }
}
