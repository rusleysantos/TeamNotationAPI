using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAnnotationAPI.Models
{
    [Table("KNOWLEDGE")]
    public class Knowledge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_KNOWLEDGE")]
        public int idKnowledge { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("TASKS")]
        public List<ExecutionTask> Tasks { get; set; }

        [Column("ATTACHMENTS")]
        public List<Attach> Attachments { get; set; }
    }
}
