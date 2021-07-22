using System.Collections.Generic;
using System.Linq;

namespace CatToys.Data
{
    public interface IGameData
    {
        IEnumerable<GameModel> GetGamesByName(string name);
        GameModel GetById(int id);
    }

    public class InMemoryGameData : IGameData
    {
        List<GameModel> games;

        public InMemoryGameData()
        {
            games = new List<GameModel>()
            {
                new GameModel {
                    Id = 1, 
                    description = "A cooperative puzzle game with subtle resource management and press-your-luck elements. You and your friends take on the role of magical puppies, escaping a crumbling temple ruin and being chased by it's ferocious guardian! Dig up gems and use them to discover and brew potions to get past each room's challenge - work together and utilize your puppy's unique abilities before the temple guardian catches you! Coming to Kickstarter soon!",
                    fulldescription = "A cooperative puzzle game with subtle resource management and press-your-luck elements. You and your friends take on the role of magical puppies, escaping a crumbling temple ruin and being chased by it's ferocious guardian! Dig up gems and use them to discover and brew potions to get past each room's challenge - work together and utilize your puppy's unique abilities before the temple guardian catches you! Coming to Kickstarter soon!",
                    GameType = GameType.family, 
                    launchDate = "10/1/2021", 
                    minAge = "8+", 
                    timeRange = "30-45 minutes", 
                    Name = "Potions and Puppies", 
                    numberOfPeople = "1-5 Players", 
                    image = "/images/puppyicon.png",
                    fullimage = "/images/puppyicon.png",
                    imageAlt = "Potions_and_Puppies_Picture",
                    launchBit = 1,
                    sellSheet = "https://boardgamegeek.com/boardgame/333293/potions-puppies",
                    BGGlink = "https://boardgamegeek.com/boardgame/333293/potions-puppies"
                },
                new GameModel {
                    Id = 2, 
                    description = "A GM-less ttrpg (cooperative narrative game) where you help each other create your own kitty - then work together to stop a malevolent ghost from haunting your human. The clock is ticking and if your human gets too scared, they'll leave without you! Work together to create a story as you climb, claw and complain your way to victory with your clowder of cat friends. Coming to Kickstarter soon-ish!",
                    fulldescription = "A GM-less ttrpg (cooperative narrative game) where you help each other create your own kitty - then work together to stop a malevolent ghost from haunting your human. The clock is ticking and if your human gets too scared, they'll leave without you! Work together to create a story as you climb, claw and complain your way to victory with your clowder of cat friends. Coming to Kickstarter soon-ish!",
                    GameType = GameType.trpg, 
                    launchDate = "11/1/2021", 
                    minAge = "8+", 
                    timeRange = "90-150 minutes", 
                    Name = "Appurritions", 
                    numberOfPeople = "2+ Players", 
                    image = "/images/caticon.png",
                    fullimage = "/images/caticon.png",
                    launchBit = 0,
                    imageAlt = "Appurritions_cat_Picture",
                    sellSheet = "https://boardgamegeek.com/boardgame/333293/potions-puppies",
                    BGGlink = "https://boardgamegeek.com/boardgame/333293/potions-puppies"
                }
            };
        }

        public GameModel GetById(int id)
        {
            return games.SingleOrDefault(g => g.Id == id);
        }

        public IEnumerable<GameModel> GetGamesByName(string name = null)
        {
            return from g in games
                   where string.IsNullOrEmpty(name) || g.Name.StartsWith(name)
                   orderby g.Name
                   select g;
        }
    }
}
