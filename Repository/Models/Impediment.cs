using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    [Table("IMPEDIMENT")]
    public class Impediment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_IMPEDIMENT")]
        public int idImpediment { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("ATTACHMENTS")]
        public List<Attach> Attachments { get; set; }

        [Column("TASKS")]
        public List<ExecutionTask> Tasks { get; set; }

        [ForeignKey("User")]
        [Column("ID_USER")]
        public int idUser { get; set; }
        public User User { get; set; }

    }
}
