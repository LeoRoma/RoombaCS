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

        public void Move(Instruction instruction)
        {
            char[] steps;
            steps = instruction.Coordinates.ToCharArray();
            
            foreach(char step in steps)
            {
                if (step.Equals('N'))
                {
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

            Console.WriteLine(steps);
            Console.WriteLine(instruction.Coordinates);
        }
    }
}
