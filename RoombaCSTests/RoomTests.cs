using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class RoomTests
    {
        [Fact()]
        public void RoomTest()
        {
            int width = 5;
            int height = 6;

            var room = new Room(width, height);

            Assert.Equal(width, room.Width);
            Assert.Equal(height, room.Height);
        }
    }
}