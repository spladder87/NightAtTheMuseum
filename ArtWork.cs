using System;

namespace NightAtTheMuseum
{
    class ArtWork
    { 
        public string title;
        public string description;
        public string author;
        public string belongToRoom;

        public ArtWork(string title, string description, string author, string belongToRoom)
        {
            this.title = title;
            this.description = description;
            this.author = author;
            this.belongToRoom = belongToRoom;

        }

    }
}
