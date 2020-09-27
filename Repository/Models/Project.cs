using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Project
    {
        [Key]
        public int idProject { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double PercentDone { get; set; }
        public List<User> User { get; set; }
        public List<Team> Team { get; set; }
    }
}
