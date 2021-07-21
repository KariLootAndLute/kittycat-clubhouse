using CatToys;
using CatToys.Data;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult OnGet(int gameId)
        {
            Game = gameData.GetById(gameId);
            if (Game == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
