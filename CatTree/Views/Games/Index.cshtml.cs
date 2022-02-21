using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatToys;
using CatToys.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CatTree.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IGameData gameData;

        public string message { get; set; }
        public IEnumerable<GameModel> games;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public IndexModel(IConfiguration config, IGameData gameData)
        { this.config = config;
            this.gameData = gameData;
        }

        public void OnGet()
        {
            //message = config["Message"];
            games = gameData.GetGamesByName(SearchTerm);
        }


    }
}
