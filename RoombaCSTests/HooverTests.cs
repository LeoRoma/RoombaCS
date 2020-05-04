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
        private Dirt _dirts;

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
            var instruction =  new Instruction("N");

            _room5x5 = new Room(5, 5);
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            _dirts = new Dirt(
                new List<RoomLocation>
                {
                        new RoomLocation(1, 0, _room5x5),
                        new RoomLocation(2, 2, _room5x5),
                        new RoomLocation(2, 3, _room5x5),
                }
            );

            var expected = $"Final hoover location is X: {_hooverLocation.X} and Y: {3}";

            var actual = _hoover.Move(instruction, _dirts);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PositionDecrementedWithS()
        {
            var instruction = new Instruction("S");

            _room5x5 = new Room(5, 5);
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            var expected = $"Final hoover location is X: {_hooverLocation.X} and Y: {1}";

            _dirts = new Dirt(
                new List<RoomLocation>
                {
                        new RoomLocation(1, 0, _room5x5),
                        new RoomLocation(2, 2, _room5x5),
                        new RoomLocation(2, 3, _room5x5),
                }
            );

            var actual = _hoover.Move(instruction, _dirts);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PositionIncrementedWithE()
        {
            
            var instruction = new Instruction("E");

            _room5x5 = new Room(5, 5);
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            var expected = $"Final hoover location is X: {2} and Y: {_hooverLocation.Y}";

            _dirts = new Dirt(
                new List<RoomLocation>
                {
                        new RoomLocation(1, 0, _room5x5),
                        new RoomLocation(2, 2, _room5x5),
                        new RoomLocation(2, 3, _room5x5),
                }
            );

            var actual = _hoover.Move(instruction, _dirts);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PositionIncrementedWithW()
        {

            var instruction = new Instruction("W");

            _room5x5 = new Room(5, 5);
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            var expected = $"Final hoover location is X: {0} and Y: {_hooverLocation.Y}";

            _dirts = new Dirt(
                new List<RoomLocation>
                {
                        new RoomLocation(1, 0, _room5x5),
                        new RoomLocation(2, 2, _room5x5),
                        new RoomLocation(2, 3, _room5x5),
                }
            );

            var actual = _hoover.Move(instruction, _dirts);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetTotalDirtCollected()
        {

            var instruction = new Instruction("NNESEESWNWW");

            _room5x5 = new Room(5, 5);
            _hooverLocation = new RoomLocation(1, 2, _room5x5);
            _hoover = new Hoover(_hooverLocation);

            var expected = 1;

            _dirts = new Dirt(
                new List<RoomLocation>
                {
                        new RoomLocation(1, 0, _room5x5),
                        new RoomLocation(2, 2, _room5x5),
                        new RoomLocation(2, 3, _room5x5),
                }
            );

            _hoover.Move(instruction, _dirts);
            var actual = _hoover.Clean(_dirts);

            Assert.Equal(expected, actual);
        }
    }
}