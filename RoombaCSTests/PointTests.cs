using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class PointTests
    {
        [Fact()]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }
    }
}