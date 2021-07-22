using System;
using System.IO;

namespace CatToys
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public string launchDate { get; set; }
        public string minAge { get; set; }
        public string numberOfPeople { get; set; }

        public string timeRange { get; set; }

        public GameType GameType { get; set; }

        public string image { get; set; }

        public string imageAlt { get; set; }

        public string fulldescription { get; set; }

        public string fullimage { get; set; }
        public string BGGlink { get; set; }
        public string sellSheet { get; set; }

    }
}
