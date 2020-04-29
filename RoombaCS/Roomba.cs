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
            string contents = File.ReadAllText(@"Input.txt", Encoding.UTF8);
          
            try
            {
                Room room = new Room(5, 5);
                Dirt dirt = new Dirt(1, 4, room);
                Hoover hoover = new Hoover("hello");
                hoover.CheckDirt(dirt);
                Console.WriteLine(room.Width + " & " + room.Height);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
