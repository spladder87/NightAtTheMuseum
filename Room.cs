using System;
using System.Collections.Generic;

namespace NightAtTheMuseum
{
    class Room
    {
        public string name;
        private List<Room> RoomAccess = new List<Room>();
        
        public void addRoomAccess(Room NewRoomAccess)
        {
            RoomAccess.Add(NewRoomAccess);
        }

        public List<Room> getRoomAccess()
        {
            return RoomAccess;
        }
        public Room (string name)
        {
            this.name = name;
        }

    }
}
