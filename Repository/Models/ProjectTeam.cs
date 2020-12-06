using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Models
{
    [Table("ProjectTeam")]
    public class ProjectTeam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PROJECTTEAM")]
        public int idProjectTeam { get; set; }

        [ForeignKey("User")]
        [Column("ID_USER")]
        public int idUser { get; set; }
        public User User { get; set; }


        [ForeignKey("Project")]
        [Column("ID_PROJECT")]
        public int idProject { get; set; }
        public Project Project { get; set; }

    }
}
