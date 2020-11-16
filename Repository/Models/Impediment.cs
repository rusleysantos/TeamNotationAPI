using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Impediment
    {
        [Key]
        public int idImpediment { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }
        public virtual List<Attach> Attachments { get; set; }
        public virtual List<ExecutionTask> Tasks { get; set; }
    }
}
