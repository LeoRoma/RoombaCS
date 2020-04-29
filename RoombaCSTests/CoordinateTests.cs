using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class CoordinateTests
    {
        [Fact()]
        public void CoordinateTest()
        {
            string step = "NNESEESWNWW";

            var coordinate = new Coordinate(step);

            Assert.Equal(step, coordinate.Step);
        }
    }
}