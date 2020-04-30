using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class Hoover : Position
    {
        public Hoover(int x, int y, Room room) : base(x, y)
        {
            if (!room.OnRoom(this))
            {
                throw new OutOfBoundsException(this + " is outside the boundaries of the room");
            }
        }
        public void CheckDirt(Dirt dirt)
        {
            Console.WriteLine(dirt.X + " & " + dirt.Y);
        }
    }
}
