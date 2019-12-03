using System;
using System.Collections.Generic;

namespace NightAtTheMuseum
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum RetroGaming = new Museum();
            createMuseum(RetroGaming);

            welcomeText(RetroGaming);
            bool runningMain = true;
            while (runningMain)
            {
                string currentRoom = roomAccessMenu(RetroGaming.getCurrentRoom(), RetroGaming);
                RetroGaming.setCurrenRoom(currentRoom);
            }

        }

        static void welcomeText(Museum museum)
        {
            Console.WriteLine($"Welcome to {museum.name}");
        }

        static string roomAccessMenu(Room room, Museum currentMuseum)
        {
            Console.WriteLine($"\nYou are in {room.name}");

            Console.WriteLine("\nCurrent art in this room:");
            foreach (var art in currentMuseum.getArtWorkInRoom(room.name))
            {
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.Write($"| Title = {art.title}\n| Description = {art.description}\n| Author = {art.author}\n");
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }

            int count = 0;
            List<string> roomNames = new List<string>();
            foreach (var Room in room.getRoomAccess())
            {
                Console.WriteLine($"[{count}] - {Room.name}");
                roomNames.Add(Room.name);
                count++;
            }

            Console.WriteLine("Please type the number of the room you want to go to");

            bool runningInputCheck = true;
            while (runningInputCheck)
            {
                string menuchoice = Console.ReadLine();
                int number;

                bool success = Int32.TryParse(menuchoice, out number);
                if (success && number < count)
                {
                    Console.Clear();
                    return roomNames[number];
                }
                else
                {
                    Console.WriteLine($"Wrong number. Enter number between 0 and {count - 1}");
                }

            }
            return "";

        }


        static void createMuseum(Museum newMuseum)
        {
            newMuseum.name = "Retro Gaming Museum";
            newMuseum.addArtWork(new ArtWork("Sonic", "Picture of Sonic the Hedgehog", "Sega", "White Room"));
            newMuseum.addArtWork(new ArtWork("Mario", "Picture of Mario from Super Mario Bros ", "Nintendo", "Purple Room"));
            newMuseum.addArtWork(new ArtWork("Luigi", "Picture of Luigi from Super Mario Bros", "Nintendo", "Purple Room"));
            newMuseum.addArtWork(new ArtWork("Yoshi", "Picture of Yoshi from Super Mario World", "Nintendo", "Purple Room"));
            newMuseum.addArtWork(new ArtWork("Toad", "Picture of Toad from Super Mario Bros", "Nintendo", "Purple Room"));
            newMuseum.addArtWork(new ArtWork("Master Chief", "Picture of Master Chief from Halo", "Xbox", "Blue Room"));
            newMuseum.addArtWork(new ArtWork("Mage", "Picture of Mage from WoW", "Blizzard", "Red Room"));
            newMuseum.addArtWork(new ArtWork("Rougw", "Picture of Rouge from WoW", "Blizzard", "Red Room"));
            newMuseum.addArtWork(new ArtWork("Hunter", "Pictue of Hunter from WoW", "Blizzard", "Red Room"));
            newMuseum.addArtWork(new ArtWork("Commander Carter", "Picture of Commander Carter from Command & Conquer", "Westwood", "Green Room"));
            newMuseum.addArtWork(new ArtWork("Kane", "Picture of Kane from Command & Conquer", "Westwood", "Green Room"));

            Room Entrance = new Room("Entrance");
            Room Hallway = new Room("Hallway");
            Room WhiteRoom = new Room("White Room");
            Room PurpleRoom = new Room("Purple Room");
            Room BlueRoom = new Room("Blue Room");
            Room RedRoom = new Room("Red Room");
            Room GreenRoom = new Room("Green Room");
            Room BlackRoom = new Room("Black Room");

            Entrance.addRoomAccess(Hallway);
            Hallway.addRoomAccess(GreenRoom);
            Hallway.addRoomAccess(Entrance);
            WhiteRoom.addRoomAccess(BlueRoom);
            PurpleRoom.addRoomAccess(RedRoom);
            PurpleRoom.addRoomAccess(BlueRoom);
            BlueRoom.addRoomAccess(WhiteRoom);
            BlueRoom.addRoomAccess(BlackRoom);
            BlueRoom.addRoomAccess(PurpleRoom);
            BlueRoom.addRoomAccess(GreenRoom);
            RedRoom.addRoomAccess(GreenRoom);
            RedRoom.addRoomAccess(PurpleRoom);
            GreenRoom.addRoomAccess(RedRoom);
            GreenRoom.addRoomAccess(BlueRoom);
            GreenRoom.addRoomAccess(Hallway);
            BlackRoom.addRoomAccess(BlueRoom);

            newMuseum.addRoom(Entrance);
            newMuseum.addRoom(Hallway);
            newMuseum.addRoom(WhiteRoom);
            newMuseum.addRoom(PurpleRoom);
            newMuseum.addRoom(BlueRoom);
            newMuseum.addRoom(RedRoom);
            newMuseum.addRoom(GreenRoom);
            newMuseum.addRoom(BlackRoom);

        }
    }
}
