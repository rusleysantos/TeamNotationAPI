using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    [Table("STATUS")]
    public class Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_STATUS")]
        public int idStatus { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("TIPO")]
        public string Tipo { get; set; }

    }
}
