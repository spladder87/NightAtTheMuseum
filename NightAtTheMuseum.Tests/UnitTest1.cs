using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using NightAtTheMuseum;

namespace NightAtTheMuseum.Tests
{
    public class UnitTest1
    {
        Museum RetroGaming = new Museum();

        [Fact]
        public void TestCreateMuseumAndCheckEntrance()
        {
            Program.CreateMuseum(RetroGaming);
            bool result = false;
            if (RetroGaming.Rooms[0].name.Equals("Entrance"))
            {
                result = true;
            }
            Assert.True(result, "First room is not Entrance");

        }

        [Fact]
        public void TestCheckArt()
        {
            bool result = false;
            Program.CreateMuseum(RetroGaming);
            if (RetroGaming.ArtWork[0].title.Equals("Sonic")
            && RetroGaming.ArtWork[10].title.Equals("Kane"))
            {
                result = true;
            }
            Assert.True(result, "First ArtWork is not Sonic Or Last ArtWork aint Kane");

        }

        [Fact]
        public void TestRoomMove()
        {
            bool result = false;
            Program.CreateMuseum(RetroGaming);
            string SetCurrentRoom = Program.RoomChoice(Program.RoomAccessMenu(RetroGaming.GetCurrentRoom()), "0");

            if (SetCurrentRoom != null)
            {
                RetroGaming.SetCurrentRoom(SetCurrentRoom);
            }
            if (RetroGaming.ShowCurrentRoom().Equals("Hallway"))
            {
                result = true;
            }
            Assert.True(result, "Room is not Hallway");

        }
    }
}
