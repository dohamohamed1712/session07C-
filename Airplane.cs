using System;
using System.Collections.Generic;
using System.Text;

namespace session07C_
{
    internal class Airplane :IMoveable ,IFlyable
    {
        public void MoveForward()
        {
            Console.WriteLine("Airplane is moving forward in the air.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Airplane is moving backward in the air.");
        }

        public void MoveUp()
        {
            Console.WriteLine("Airplane is moving up.");
        }

        public void MoveDown()
        {
            Console.WriteLine("Airplane is moving down.");
        }
    }
}
