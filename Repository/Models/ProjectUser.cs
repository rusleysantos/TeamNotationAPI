using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Models
{
    [Table("ProjectUser")]
    public class ProjectUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PROJECTUSER")]
        public int idProjectUser { get; set; }

        [ForeignKey("User")]
        [Column("ID_USER")]
        public int idUser { get; set; }
        public User User { get; set; }

        [ForeignKey("Project")]
        [Column("ID_PROJECT")]
        public int idProject { get; set; }
        [Column("PROJECT")]
        public Project Project { get; set; }

    }
}
