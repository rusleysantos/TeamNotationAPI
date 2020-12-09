using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    [Table("NOTATION")]
    public class Notation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_NOTATION")]
        public int idNotation { get; set; }
        
        [Column("TITLE")]
        public string Title { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("ATTACHMENTS")]
        public List<Attach> Attachments { get; set; }

        [Column("POSITIONCARD")]
        public string PositionCard { get; set; }

        [ForeignKey("User")]
        [Column("ID_USER")]
        public int idUser { get; set; }
        public User User { get; set; }

        [ForeignKey("Project")]
        [Column("ID_PROJECT")]
        public int idProject { get; set; }
        public Project Project { get; set; }

        [Column("DELETED")]
        public bool Deleted { get; set; }

    }
}
