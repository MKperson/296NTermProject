using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _296NTermProject.Repositorys;

namespace _296NTermProject.Controllers
{
    public class GameController : Controller
    {
        private IGameRepo gameRepo;
        public GameController(IGameRepo gameRepo)
        {
            this.gameRepo = gameRepo;
        }
        public IActionResult Index()
        {
            var games = gameRepo.GetAllGames();
            return View(games);
        }
    }
}