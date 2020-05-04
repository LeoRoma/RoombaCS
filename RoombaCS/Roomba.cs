using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace RoombaCS
{
    public class Roomba
    {
        static void Main(string[] args)
        {
            //string contents = File.ReadAllText(@"Input.txt", Encoding.UTF16);

            try
            {
                Room room = new Room(5, 5);

                Hoover hoover = new Hoover(new RoomLocation(1, 2, room));

                Dirt dirts = new Dirt(
                    new List<RoomLocation>
                    {
                        new RoomLocation(1, 0, room),
                        new RoomLocation(2, 2, room),
                        new RoomLocation(2, 3, room),
                    }
                );

                Instruction instruction = new Instruction("NNESEESWNWW");

                hoover.Move(instruction, dirts, room);
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex);
            }

            catch (HitWallException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
