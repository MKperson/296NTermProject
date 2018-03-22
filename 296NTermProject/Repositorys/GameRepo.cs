using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _296NTermProject.Models;
using _296NTermProject.Data;
using Microsoft.EntityFrameworkCore;


namespace _296NTermProject.Repositorys
{
    public class GameRepo : IGameRepo
    {
        private readonly ApplicationDbContext context;

        public GameRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public int AddGame(Game game)
        {
            context.Games.Update(game);
            context.SaveChanges();
            foreach (Developer d in game.Developers)
            {
                d.GameID = game.GameID;
                context.Developers.Update(d);
            }

            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            var gameFromDb = context.Games.First(a => a.GameID == id);
            context.Remove(gameFromDb);
            return context.SaveChanges();
        }

        public int Edit(Game game)
        {
            context.Games.Update(game);
            return context.SaveChanges();
        }

        public List<Game> GetAllGames()
        {
            return context.Games.Include(g => g.Developers).ToList();
        }

        public List<Developer> GetDevelopersByGame(Game game)
        {
            throw new NotImplementedException();
        }

        public Game GetgameById(int id)
        {
            return context.Games.Include("Developers").First(g => g.GameID == id);
        }
    }
}
