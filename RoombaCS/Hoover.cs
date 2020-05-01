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

        public string Move(Instruction instruction)
        {
            char[] steps;
            steps = instruction.Coordinates.ToCharArray();
            
            foreach(char step in steps)
            {
                if (step.Equals('N'))
                {
                    Location.Y += 1;
                }

                if (step.Equals('S'))
                {
                    Location.Y -= 1;
                }

                if (step.Equals('E'))
                {
                    Location.X += 1;
                }

                if (step.Equals('W'))
                {
                    Location.X -= 1;
                }
            }
            Console.WriteLine($"Final hoover location is X: {Location.X} and Y: {Location.Y}");
            return $"Final hoover location is X: {Location.X} and Y: {Location.Y}";
            
        }

        public void Clean(Dirt dirts)
        {
            foreach (var dirt in dirts.Location)
            {
                Console.WriteLine(dirt.X + " & " + dirt.Y);
            }
        }
    }
}
