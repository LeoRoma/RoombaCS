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

        public string Move(Instruction instruction, Dirt dirts)
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

                Clean(dirts);
            }
            Console.WriteLine($"Final hoover location is X: {Location.X} and Y: {Location.Y}");
            return $"Final hoover location is X: {Location.X} and Y: {Location.Y}";
            
        }

        public int Clean(Dirt dirts)
        {
            foreach (var dirt in dirts.Location)
            {
                Console.WriteLine($"hoover location is X: {Location.X} and Y: {Location.Y}");
                Console.WriteLine($"dirt location is X: {dirt.X} and Y: {dirt.Y}");
                Console.WriteLine("--------------");
                if (Location.X.Equals(dirt.X) && Location.Y.Equals(dirt.Y))
                {

                    dirtCollected += 1;
                }
             }
            Console.WriteLine($"Hoover totals dirt collected is: {dirtCollected}");
            return dirtCollected;
        }
    }
}
