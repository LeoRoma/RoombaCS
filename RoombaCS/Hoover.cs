using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class Hoover 
    {
        public RoomLocation Location;
        
        public Hoover(RoomLocation location)
        {
            Location = location;
        }

        public void CheckDirt(Dirt dirt)
        {
            Console.WriteLine("I am dirt " + dirt.Location[0].X);
        }

        public void Move(Instruction instruction)
        {
            char[] steps;
            steps = instruction.Coordinates.ToCharArray();
            
            foreach(char step in steps)
            {
                if (step.Equals('N'))
                {
                    Location.Y += 1;
                   Console.WriteLine("urray N");
                }

                if (step.Equals('S'))
                {
                    Console.WriteLine("urray S");
                }

                if (step.Equals('E'))
                {
                    Console.WriteLine("urray E");
                }

                if (step.Equals('W'))
                {
                    Console.WriteLine("urray W");
                }
            }

            Console.WriteLine(Location.X + " & " + Location.Y);
            Console.WriteLine(instruction.Coordinates);
        }
    }
}
