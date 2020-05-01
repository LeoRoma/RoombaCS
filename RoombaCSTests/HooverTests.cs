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
        public void PositionIncrementedWithN()
        {
            _room5x5 = new Room(5, 5);
            var instruction =  new Instruction("N");
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);
            Console.WriteLine(_hooverLocation.Y);
            _hooverLocation.X = 3;
            var expected = _hooverLocation.X;

            var actual = _hoover.Move(instruction);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PositionDecrementedWithS()
        {
            _room5x5 = new Room(5, 5);
            var instruction = new Instruction("S");
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            _hooverLocation.Y = 1;
            var expected = _hooverLocation.Y;

            var actual = _hoover.Move(instruction);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PositionIncrementedWithE()
        {
            _room5x5 = new Room(5, 5);
            var instruction = new Instruction("E");
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            _hooverLocation.Y = 2;
            var expected = _hooverLocation.Y;

            var actual = _hoover.Move(instruction);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PositionIncrementedWithW()
        {
            _room5x5 = new Room(5, 5);
            var instruction = new Instruction("W");
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            _hooverLocation.Y = 0;
            var expected = _hooverLocation.Y;

            var actual = _hoover.Move(instruction);

            Assert.Equal(expected, actual);
        }
    }
}