using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    [Table("ADDRESS")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_ADDRESS")]
        public int idAddress { get; set; }

        [Column("NUMBER")]
        public int Number { get; set; }

        [Column("STREET")]
        public string Street { get; set; }

        [Column("COUNTRIE")]
        public string Countrie { get; set; }

        [Column("LATITUDE")]
        public string Latitude { get; set; }

        [Column("LONGITUDE")]
        public string Longitude { get; set; }
    }
}
