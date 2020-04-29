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
            try
            {
                Room room = new Room(5, 5);
                Console.WriteLine(room.Width + " & " + room.Height);

             
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
