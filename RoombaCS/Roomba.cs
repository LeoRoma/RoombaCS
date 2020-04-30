﻿using System;
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

                Dirt dirt = new Dirt(
                    new[]
                    {
                        new RoomLocation(1, 0, room),
                        new RoomLocation(2, 2, room),
                        new RoomLocation(2, 3, room),
                    }
                );

                Instruction instruction = new Instruction("NNESEESWNWW");
                hoover.CheckDirt(dirt);
                Console.WriteLine(room.Width + " & " + room.Height + " I am Room size");
                hoover.Move(instruction);
                //Console.WriteLine(hoover.MapLocation.X + " & " + hoover.Y + " I am Hoover position");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
