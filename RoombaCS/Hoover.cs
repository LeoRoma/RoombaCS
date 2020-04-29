using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class Hoover
    {
        public readonly string Step;

        public Hoover(string step) 
        {
            Step = step;
        }
        public void CheckDirt(Dirt dirt)
        {
            Console.WriteLine(dirt.X + " & " + dirt.Y);
        }
    }
}
