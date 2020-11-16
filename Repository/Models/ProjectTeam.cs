using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Models
{
    public class ProjectTeam
    {
        [Key]
        public int idProjectTeam { get; set; }
        public Project Project { get; set; }
        public Team Team { get; set; }
    }
}
