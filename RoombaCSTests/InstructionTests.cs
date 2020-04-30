using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class InstructionTests
    {
        [Fact()]
        public void InstructionTest()
        {
            var coordinates = "NNESEESWNWW";
            var instruction = new Instruction(coordinates);

            Assert.Equal(coordinates, instruction.Coordinates);
        }
    }
}