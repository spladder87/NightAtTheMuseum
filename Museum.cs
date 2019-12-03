using System;
using System.Collections.Generic;
using System.Linq;


namespace NightAtTheMuseum
{
    class Museum
    {
        public string name;
        public List<Room> Rooms = new List<Room>();
        public List<ArtWork> ArtWork = new List<ArtWork>();

        private string CurrentRoom = "Entrance";

        public void addRoom(Room NewRoom)
        {
            Rooms.Add(NewRoom);
        }
        public void addArtWork(ArtWork NewArtWork)
        {
            ArtWork.Add(NewArtWork);
        }
        public List<ArtWork> getArtWorkInRoom(string ArtWorkInRoom)
        {
            List<ArtWork> artWorkInRoom = new List<ArtWork>();

            foreach (var artWork in ArtWork)
            {
                if (artWork.belongToRoom.Equals(ArtWorkInRoom))
                {
                    artWorkInRoom.Add(artWork);
                }
            }

            return artWorkInRoom;
        }

        public Room getCurrentRoom()
        {
            foreach (var room in Rooms)
            {
                if(room.name.Equals(CurrentRoom))
                {
                    Room currentRoom = room;
                    return currentRoom;
                }
            }
            return null;


        }
        public void setCurrenRoom(string CurrentRoom)
        {
            this.CurrentRoom = CurrentRoom;
        }

    }
}
