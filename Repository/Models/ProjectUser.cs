using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Models
{
    public class ProjectUser
    {
        [Key]
        public int idProjectUser { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }
    }
}
