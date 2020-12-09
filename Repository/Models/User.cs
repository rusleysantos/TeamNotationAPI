using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    [Table("USER")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_USER")]
        public int idUser { get; set; }

        [Column("LOGIN")]
        public string Login { get; set; }

        [Column("PASSWORD")]
        public string Password { get; set; }

        [ForeignKey("Address")]
        [Column("ID_ADDRESS")]
        public int? idAddress { get; set; }
        public Address Address { get; set; }


        [ForeignKey("Profile")]
        [Column("ID_PROFILE")]
        public int? idProfile { get; set; }
        public Profile Profile { get; set; }

    }
}
