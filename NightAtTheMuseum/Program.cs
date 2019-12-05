using System;
using System.Collections.Generic;

namespace NightAtTheMuseum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Museum RetroGaming = new Museum();
            CreateMuseum(RetroGaming);

            WelcomeText(RetroGaming);
            bool runningMain = true;
            while (runningMain)
            {
                ShowArtInRoom(RetroGaming.GetCurrentRoom(), RetroGaming);

                Console.WriteLine("Please type the number of the room you want to go to");

                string SetCurrentRoom = RoomChoice(RoomAccessMenu(RetroGaming.GetCurrentRoom()), Console.ReadLine());

                if (SetCurrentRoom != null)
                {
                    Console.Clear();
                    RetroGaming.SetCurrentRoom(SetCurrentRoom);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong number, please try again");
                }
            }

        }

        static void WelcomeText(Museum museum)
        {
            Console.WriteLine($"Welcome to {museum.name}");
        }

        public static string RoomChoice(List<string> roomNames,string menuchoice)
        {
                int number;
                bool success = Int32.TryParse(menuchoice, out number);
                if (success && number < roomNames.Count)
                {
                    return roomNames[number];
                }
                else
                {
                    return null;   
                }
            }


        public static List<string> RoomAccessMenu(Room room)
        {
            Console.WriteLine($"\nYou are in {room.name}");

            int count = 0;
            List<string> roomNames = new List<string>();
            foreach (var Room in room.GetRoomAccess())
            {
                Console.WriteLine($"[{count}] - {Room.name}");
                roomNames.Add(Room.name);
                count++;
            }
            return roomNames;
        }

        static void ShowArtInRoom(Room room, Museum currentMuseum)
        {
            Console.WriteLine("\nCurrent art in this room:");
            foreach (var art in currentMuseum.GetArtWorkInRoom(room.name))
            {
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.Write($"| Title = {art.title}\n| Description = {art.description}\n| Author = {art.author}\n");
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
        }


        public static void CreateMuseum(Museum newMuseum)
        {
            newMuseum.name = "Retro Gaming Museum";
            newMuseum.AddArtWork(new ArtWork("Sonic", "Picture of Sonic the Hedgehog", "Sega", "White Room"));
            newMuseum.AddArtWork(new ArtWork("Mario", "Picture of Mario from Super Mario Bros ", "Nintendo", "Purple Room"));
            newMuseum.AddArtWork(new ArtWork("Luigi", "Picture of Luigi from Super Mario Bros", "Nintendo", "Purple Room"));
            newMuseum.AddArtWork(new ArtWork("Yoshi", "Picture of Yoshi from Super Mario World", "Nintendo", "Purple Room"));
            newMuseum.AddArtWork(new ArtWork("Toad", "Picture of Toad from Super Mario Bros", "Nintendo", "Purple Room"));
            newMuseum.AddArtWork(new ArtWork("Master Chief", "Picture of Master Chief from Halo", "Xbox", "Blue Room"));
            newMuseum.AddArtWork(new ArtWork("Mage", "Picture of Mage from WoW", "Blizzard", "Red Room"));
            newMuseum.AddArtWork(new ArtWork("Rougw", "Picture of Rouge from WoW", "Blizzard", "Red Room"));
            newMuseum.AddArtWork(new ArtWork("Hunter", "Pictue of Hunter from WoW", "Blizzard", "Red Room"));
            newMuseum.AddArtWork(new ArtWork("Commander Carter", "Picture of Commander Carter from Command & Conquer", "Westwood", "Green Room"));
            newMuseum.AddArtWork(new ArtWork("Kane", "Picture of Kane from Command & Conquer", "Westwood", "Green Room"));

            Room Entrance = new Room("Entrance");
            Room Hallway = new Room("Hallway");
            Room WhiteRoom = new Room("White Room");
            Room PurpleRoom = new Room("Purple Room");
            Room BlueRoom = new Room("Blue Room");
            Room RedRoom = new Room("Red Room");
            Room GreenRoom = new Room("Green Room");
            Room BlackRoom = new Room("Black Room");

            Entrance.AddRoomAccess(Hallway);
            Hallway.AddRoomAccess(GreenRoom);
            Hallway.AddRoomAccess(Entrance);
            WhiteRoom.AddRoomAccess(BlueRoom);
            PurpleRoom.AddRoomAccess(RedRoom);
            PurpleRoom.AddRoomAccess(BlueRoom);
            BlueRoom.AddRoomAccess(WhiteRoom);
            BlueRoom.AddRoomAccess(BlackRoom);
            BlueRoom.AddRoomAccess(PurpleRoom);
            BlueRoom.AddRoomAccess(GreenRoom);
            RedRoom.AddRoomAccess(GreenRoom);
            RedRoom.AddRoomAccess(PurpleRoom);
            GreenRoom.AddRoomAccess(RedRoom);
            GreenRoom.AddRoomAccess(BlueRoom);
            GreenRoom.AddRoomAccess(Hallway);
            BlackRoom.AddRoomAccess(BlueRoom);

            newMuseum.AddRoom(Entrance);
            newMuseum.AddRoom(Hallway);
            newMuseum.AddRoom(WhiteRoom);
            newMuseum.AddRoom(PurpleRoom);
            newMuseum.AddRoom(BlueRoom);
            newMuseum.AddRoom(RedRoom);
            newMuseum.AddRoom(GreenRoom);
            newMuseum.AddRoom(BlackRoom);

        }
    }
}
