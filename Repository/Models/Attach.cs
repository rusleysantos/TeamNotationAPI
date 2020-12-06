using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    [Table("AttachT")]
    public class Attach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_ATTACH")]
        public int idAttach { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("TYPE")]
        public string Type { get; set; }

        [Column("BLOB")]
        public byte Blob { get; set; }
    }
}
