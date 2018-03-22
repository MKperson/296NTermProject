using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _296NTermProject.Models
{
    public class Developer
    {
        public int DeveloperID { get; set; }   // PK
        public int GameID { get; set; }     // FK
        public string CompanyName { get; set; }
        
    }
}
