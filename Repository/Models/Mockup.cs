using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace TeamAnnotationAPI.Models
{
    [Table("MOCKUP")]
    public class Mockup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_MOCKUP")]
        public int idMockup { get; set; }

        [Column("TYPE")]
        public string Type { get; set; }

        [Column("BLOB")]
        public byte Blob { get; set; }
    }
}
