using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _296NTermProject.Models;

namespace _296NTermProject.Repositorys
{
    public interface IGameRepo
    {
        List<Game> GetAllGames();
       
        Game GetgameById(int id);     
        List<Developer> GetDevelopersByGame(Game game);
        int AddGame(Game game);
        int Edit(Game game);
        int Delete(int id);
    }
}
