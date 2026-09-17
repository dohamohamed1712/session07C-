using System;
using System.Collections.Generic;
using System.Text;

namespace session07C_
{
    internal class Car : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Car is moving forward on the ground.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car is moving backward on the ground.");
        }
    }
}
