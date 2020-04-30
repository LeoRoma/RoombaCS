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

                Hoover hoover = new Hoover(1, 2, room);

                //Dirt dirt = new Dirt(
                //   new[] {
                //    Dirt dirt1 = new Dirt(1, 0, room);
                //Dirt dirt2 = new Dirt(2, 2, room);
                //Dirt dirt3 = new Dirt(2, 3, room);
                //    }
                //);
                

                Instruction instruction = new Instruction("NNESEESWNWW");
                //hoover.CheckDirt();
                Console.WriteLine(room.Width + " & " + room.Height + " I am Room size");
                hoover.Move(instruction);
                Console.WriteLine(hoover.X + " & " + hoover.Y + " I am Hoover position");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
