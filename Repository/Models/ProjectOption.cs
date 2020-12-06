using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    [Table("ProjectOption")]
    public class ProjectOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PROJECTOPTION")]
        public int idProjectOption { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("PERCENTDONE")]
        public double PercentDone { get; set; }
    }
}
