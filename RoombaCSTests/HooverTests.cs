using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class HooverTests
    {
        [Fact()]
        public void CheckPositionOfRoom()
        {
            var room = new Room(5, 5);
            var exception = Assert.Throws<OutOfBoundsException>(() => new Hoover(6, 6, room));
        }
    }
}