using CatToys;
using CatToys.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CatTree.Pages.Games
{
    public class DetailModel : PageModel
    {
        private readonly IGameData gameData;
        public GameModel Game { get; set; } 

        public DetailModel(IGameData gameData)
        {
            this.gameData = gameData;
        }

        public void OnGet(int gameId)
        {
            Game = gameData.GetById(gameId);
        }
    }
}
