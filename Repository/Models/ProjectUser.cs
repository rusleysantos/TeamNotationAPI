using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Models
{
    [Table("PROJECT_USER")]
    public class PROJECT_USER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PROJECT_USER")]
        public int idPROJECT_USER { get; set; }

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
