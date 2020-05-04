using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS
{
    public class RoombaExceptions : SystemException
    {
        public RoombaExceptions()
        { }

        public RoombaExceptions(string message) : base(message)
        { }
    }

    public class OutOfBoundsException : RoombaExceptions
    {
        public OutOfBoundsException()
        { }

        public OutOfBoundsException(string message) : base(message)
        { }
    }

    public class HitWallException : RoombaExceptions
    {
        public HitWallException()
        { }

        public HitWallException(string message) : base(message)
        { }
    }

}


