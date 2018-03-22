using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _296NTermProject.Models
{
    public class Game
    {
        private List<Developer> developers = new List<Developer>();
        public List<Developer> Developers { get { return developers; } }

        

        public int GameID { get; set; }     // PK

        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }

}

