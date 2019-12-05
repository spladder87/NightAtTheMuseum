using System;
using System.Collections.Generic;

namespace NightAtTheMuseum
{
    public class Room
    {
        public string name;
        private List<Room> RoomAccess = new List<Room>();
        
        public void AddRoomAccess(Room NewRoomAccess)
        {
            RoomAccess.Add(NewRoomAccess);
        }

        public List<Room> GetRoomAccess()
        {
            return RoomAccess;
        }
        public Room (string name)
        {
            this.name = name;
        }

    }
}
