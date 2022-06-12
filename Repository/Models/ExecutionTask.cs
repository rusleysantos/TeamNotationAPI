using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAnnotationAPI.Models
{
    [Table("EXECUTION_TASK")]
    public class ExecutionTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_TASK")]
        public int idTask { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("WEIGHT")]
        public string Weight { get; set; }

        [Column("EFFORT")]
        public string Effort { get; set; }

        [Column("COLOR_BACKGROUND")]
        public string ColorBackground { get; set; }

        [Column("COLOR_TEXT")]
        public string ColorText { get; set; }

        [Column("BACKLOGS")]
        public List<Backlog> Backlogs { get; set; }

        [Column("ATTACHMENTS")]
        public List<Attach> Attachments { get; set; }

        [ForeignKey("Status")]
        [Column("ID_STATUS")]
        public int idStatus { get; set; }
        public Status Status { get; set; }

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

        [Column("ANNOTATIONS")]
        public List<Annotation> Annotations { get; set; }

        [Column("SEQUENCE_NUMBER")]
        public int SequenceNumber { get; set; }
    }
}
