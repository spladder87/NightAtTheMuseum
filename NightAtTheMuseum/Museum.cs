using System;
using System.Collections.Generic;
using System.Linq;


namespace NightAtTheMuseum
{
    public class Museum
    {
        public string name;
        public List<Room> Rooms = new List<Room>();
        public List<ArtWork> ArtWork = new List<ArtWork>();

        private string CurrentRoom = "Entrance";

        public void AddRoom(Room NewRoom)
        {
            Rooms.Add(NewRoom);
        }
        public void AddArtWork(ArtWork NewArtWork)
        {
            ArtWork.Add(NewArtWork);
        }
        public List<ArtWork> GetArtWorkInRoom(string ArtWorkInRoom)
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

        public Room GetCurrentRoom()
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
        public void SetCurrentRoom(string CurrentRoom)
        {
            this.CurrentRoom = CurrentRoom;
        }
        public string ShowCurrentRoom()
        {
            return CurrentRoom;
        }

    }
}
