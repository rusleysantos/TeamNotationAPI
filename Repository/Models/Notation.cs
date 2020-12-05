using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Notation
    {
        [Key]
        public int idNotation { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
        public List<Attach> Attachments { get; set; }
        public string PositionCard { get; set; }

        [NotMapped]
        [ForeignKey("FK_Notation_Project_ProjectidProject")]
        public int ProjectidProject { get; set; }

        [NotMapped]
        [ForeignKey("FK_Notation_User_UseridUser")]
        public int UseridUser { get; set; }
    }
}
