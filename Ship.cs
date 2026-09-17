using System;
using System.Collections.Generic;
using System.Text;

namespace session07C_
{
    internal class Ship :IMoveable
    {
        void IMoveable.MoveForward()
        {
            Console.WriteLine("Ship is moving forward on the sea. (Explicit)");
        }


        public void MoveBackward()
        {
            Console.WriteLine("Ship is moving backward on the sea.");
        }
    }
}
