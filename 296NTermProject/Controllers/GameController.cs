using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _296NTermProject.Repositorys;
using _296NTermProject.Models;

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
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Add(string title, string date, string developer)
        {
            Game game = new Game { Title = title, Date = DateTime.Parse(date) };
            if (developer != null)
            {
                game.Developers.Add(new Developer { CompanyName = developer });
            }

            gameRepo.AddGame(game);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            return View(gameRepo.GetgameById(id));
        }

        [HttpPost]
        public RedirectToActionResult Edit(Game game)
        {
            gameRepo.Edit(game);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            gameRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}