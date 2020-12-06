using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    [Table("Backlog")]
    public class Backlog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_BACKLOG")]
        public int idBacklog { get; set; }

        [Column("CATEGORY")]
        public string Category { get; set; }

        [Column("PRECEDENCE")]
        public string Precedence { get; set; }

        [Column("ESTIMATE")]
        public string Estimate { get; set; }

        [Column("IMPORTANCE")]
        public string Importance { get; set; }

        [Column("STORY")]
        public string Story { get; set; }

        [ForeignKey("Project")]
        [Column("ID_PROJECT")]
        public int idProject { get; set; }
        public Project Project { get; set; }

        [ForeignKey("Mockup")]
        [Column("ID_MOCKUP")]
        public int idMockup { get; set; }
        public Mockup Mockup { get; set; }

        [ForeignKey("FK_Status_idStatus_Backlog_idStatus")]
        [Column("ID_STATUS")]
        public int idStatus { get; set; }
        public Status Status { get; set; }

    }
}
