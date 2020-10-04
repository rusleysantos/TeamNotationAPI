using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Knowledge
    {
        [Key]
        public int idKnowledge { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ExecutionTask> Tasks { get; set; }
        public List<Attach> Attachments { get; set; }
    }
}
