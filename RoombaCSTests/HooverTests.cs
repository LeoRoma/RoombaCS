using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class HooverTests
    {
        private Room _room5x5;
        private RoomLocation _hooverLocation;
        private Hoover _hoover;

        [Fact()]
        public void CheckPositionOnRoom()
        {
            _room5x5 = new Room(5, 5);
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);
        }

        [Fact]
        public void IncrementedPositionWithN()
        {
            _room5x5 = new Room(5, 5);
            var instruction =  new Instruction("N");
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            _hooverLocation.X = 2;
            var expected = _hooverLocation.X;

            var actual = _hoover.Move(instruction);

            Assert.Equal(expected, actual);
        }
    }
}