using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Task
    {
        [Key]
        public int idTask { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Effort { get; set; }
        public List<Backlog> Backlogs { get; set; }
        public StatusTask Status { get; set; }
        public Task MainTask { get; set; }
        public User User { get; set; }
        public List<Attach> Attachments { get; set; }
    }
}
