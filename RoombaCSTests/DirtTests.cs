using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class DirtTests
    {
        [Fact()]
        public void DirtTest()
        {
            var room = new Room(5, 5);
            var exception = Assert.Throws<OutOfBoundsException>(() => new Dirt(6, 6, room));
        }
    }
}