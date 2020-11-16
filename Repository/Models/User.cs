using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class User
    {
        [Key]
        public int idUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Address Address { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
