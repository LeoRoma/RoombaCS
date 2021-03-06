﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class RoomLocation : Position
    {
        public RoomLocation(int x, int y, Room room) : base(x, y)
        {
            if (!room.OnRoom(this))
            {
                throw new OutOfBoundsException(this + " is outside the boundaries of the room");
            }
        }
    }
}
