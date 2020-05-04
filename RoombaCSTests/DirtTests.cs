using Xunit;
using RoombaCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoombaCS.Tests
{
    public class DirtTests
    {
        private Room _room5x5;
        private List<RoomLocation> _dirtLocations3;
        private Dirt _dirt3;

        [Fact()]
        public void DirtTest()
        {
            _room5x5 = new Room(5, 5);

            _dirtLocations3 = new List<RoomLocation>
            {
                new RoomLocation(1, 0, _room5x5),
                new RoomLocation(2, 2, _room5x5),
                new RoomLocation(2, 3, _room5x5),
            };

            _dirt3 = new Dirt(_dirtLocations3);
        }
    }
}