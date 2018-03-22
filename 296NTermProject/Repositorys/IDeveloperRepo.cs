using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _296NTermProject.Models;

namespace _296NTermProject.Repositorys
{
    
        public interface IDeveloperRepo
        {
          
            List<Developer> GetAllDevelopers();
            Developer GetDeveloperById(int id);
            int Add(Developer developer);
            int Edit(Developer developer);
            int Delete(int id);

        }
    

}
