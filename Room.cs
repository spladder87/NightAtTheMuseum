using System;

namespace NightAtTheMuseum
{
    class Room
    {
        public string name;
        private List<Room> RoomAccess = new Room();
        
        public void addRoomAccess(Room NewRoomAccess)
        {
            RoomAccess.Add(NewRoomAccess);

        }

        public List<Room> getRoomAccess()
        {
            return RoomAccess;
        }

    }
}
