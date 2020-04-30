using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class Hoover 
    {
        private readonly RoomLocation _location;
        
        public Hoover(RoomLocation location)
        {
            _location = location;
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
                    _location.Y += 1;
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

            Console.WriteLine(_location.X + " & " + _location.Y);
            Console.WriteLine(instruction.Coordinates);
        }
    }
}
