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
            int height = 5;

            var room = new Room(width, height);

            Assert.Equal(width, room.Width);
            Assert.Equal(height, room.Height);
        }

        [Fact]
        public void CheckPositionIsOnRoom()
        {
            var room = new Room(5, 5);
            var point = new Position(2, 3);

            var expected = true;

            Assert.Equal(expected, room.OnRoom(point));
        }

        [Fact]
        public void CheckPositionIsNotOnRoom()
        {
            var room = new Room(5, 5);
            var point = new Position(6, 6);

            var expected = false;

            Assert.Equal(expected, room.OnRoom(point));
        }
    }
}