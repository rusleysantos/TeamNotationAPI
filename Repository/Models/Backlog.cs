using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Backlog
    {
        [Key]
        public int idBacklog { get; set; }
        public int Category { get; set; }
        public int Precedence { get; set; }
        public int Estimate { get; set; }
        public int Importance { get; set; }
        public int Story { get; set; }
        public Project Project { get; set; }
        public Mockup Mockup { get; set; }
        public Status Status { get; set; }
    }
}
