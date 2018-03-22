using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _296NTermProject.Repositorys;
using Microsoft.AspNetCore.Authorization;
using _296NTermProject.Models;

namespace _296NTermProject.Controllers
{
    public class DeveloperController : Controller
    {
        private IDeveloperRepo developerRepo;

        public DeveloperController(IDeveloperRepo repo)
        {
            developerRepo = repo;
        }

        

        public ViewResult Index()
        {
            var authors = developerRepo.GetAllDevelopers();
            return View(authors);
        }



        [HttpPost]
        [Authorize]
        public RedirectToActionResult Add(string name, DateTime date, int gameId)
        {
            developerRepo.Add(new Developer { CompanyName = name, GameID = gameId });
            return RedirectToAction("Index", "Game");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            return View("DeveloperEntry", developerRepo.GetDeveloperById(id));
        }

        [HttpPost]
        public RedirectToActionResult Edit(String name, int developerid, int gameid)
        {
            Developer developer = new Developer
            {
                CompanyName = name,
                DeveloperID = developerid,
                GameID = gameid
            };

            developerRepo.Edit(developer);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            developerRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

    
