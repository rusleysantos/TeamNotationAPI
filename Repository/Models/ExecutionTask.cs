using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class ExecutionTask
    {
        [Key]
        public int idTask { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Effort { get; set; }
        public virtual List<Backlog> Backlogs { get; set; }
        public virtual Status Status { get; set; }
        public virtual ExecutionTask MainTask { get; set; }
        public virtual User User { get; set; }
        public virtual List<Attach> Attachments { get; set; }
    }
}
