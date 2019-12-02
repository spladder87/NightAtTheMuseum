using System;

namespace NightAtTheMuseum
{
    class Museum
    {
        private List<Room> Rooms = new Room();
        private List<ArtWork> ArtWork = new ArtWork();

        private string CurrentRoom = "entrance";

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
            List<ArtWork> ArtWorkInRoom = new ArtWork();

            foreach (var artWork in ArtWork)
            {
                if (artWork.belongToRoom.Equals(ArtWorkInRoom))
                {
                    ArtWorkInRoom.Add(artWork);
                }
            }

            return ArtWorkInRoom;
        }

        public Room getCurrentRoom()
        {
            var match = Rooms
            .Where(x => x.Contains(CurrentRoom)).FirstOrDefault();

            if (match != null)
            {
                return match;
            }
        }
        public void setCurrenRoom(string CurrentRoom)
        {
            this.CurrentRoom = CurrentRoom;
        }




    }
}
