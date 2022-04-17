using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAnnotationAPI.Models
{
    [Table("PROJECT")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PROJECT")]
        public int idProject { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("PERCENTDONE")]
        public double PercentDone { get; set; }

        [Column("EXECUTIONTASKS")]
        public List<ExecutionTask> ExecutionTasks { get; set; }

    }
}
