using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class PositionTests
    {
        [Fact()]
        public void PositionTest()
        {
            int x = 5;
            int y = 6;

            var point = new Position(x, y);

            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }
    }
}