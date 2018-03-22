using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _296NTermProject.Data;
using _296NTermProject.Models;

namespace _296NTermProject.Repositorys
{
    public class DeveloperRepo : IDeveloperRepo
    {
        private ApplicationDbContext context;

        public DeveloperRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public int Add(Developer developer)
        {
            context.Developers.Add(developer);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            var developerFromDb = context.Developers.First(a => a.DeveloperID == id);
            context.Remove(developerFromDb);
            return context.SaveChanges();
        }

        public int Edit(Developer developer)
        {
            var developerFromDb = GetDeveloperById(developer.DeveloperID);
            
            developerFromDb.CompanyName = developer.CompanyName;
            developerFromDb.GameID = developer.GameID;
            return context.SaveChanges();
        }

        public List<Developer> GetAllDevelopers()
        {
            List<Developer> developers = context.Developers.ToList<Developer>();
            return developers;
        }

        public Developer GetDeveloperById(int id)
        {
            return context.Developers.First(a => a.DeveloperID == id);
        }
    }
}
