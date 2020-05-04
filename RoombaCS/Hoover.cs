using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class Hoover
    {
        public RoomLocation Location;
        private int dirtCollected;

        public Hoover(RoomLocation location)
        {
            Location = location;
            dirtCollected = 0;
        }

        public string Move(Instruction instruction, Dirt dirts, Room room)
        {
            char[] steps;
            steps = instruction.Coordinates.ToCharArray();

            foreach (char step in steps)
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

                if (Location.X < 0 || Location.Y > room.Width || Location.Y < 0 || Location.Y > room.Height)
                {
                    throw new HitWallException("Sorry hoover can't go further");
                }
                Clean(dirts);
            }
            Console.WriteLine($"Final hoover location is X: {Location.X} and Y: {Location.Y}");
            return $"Final hoover location is X: {Location.X} and Y: {Location.Y}";

        }

        public int Clean(Dirt dirts)
        {
            foreach (var dirt in dirts.Location.ToArray())
            {
                if (Location.X.Equals(dirt.X) && Location.Y.Equals(dirt.Y))
                {
                    dirts.Location.Remove(dirt);
                    dirtCollected += 1;
                }
            }
            Console.WriteLine($"Hoover totals dirt collected is: {dirtCollected}");
            return dirtCollected;
        }
    }
}
