using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class Room
    {
        public readonly int Width;
        public readonly int Height;

        public Room(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnRoom(Position point)
        {
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;
        }
    }
}
