using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class RoomLocationTests
    {
        [Fact()]
        public void RoomLocationTest()
        {
            var room = new Room(5, 5);
            var exception = Assert.Throws<OutOfBoundsException>(() => new RoomLocation(6, 6, room));
        }
    }
}