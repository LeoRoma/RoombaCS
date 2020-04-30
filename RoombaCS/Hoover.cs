using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class Hoover
    {
        public readonly int X;
        public readonly int Y;

        public Hoover(int x, int y) 
        {
            X = x;
            Y = y;
        }
        public void CheckDirt(Dirt dirt)
        {
            Console.WriteLine(dirt.X + " & " + dirt.Y);
        }
    }
}
