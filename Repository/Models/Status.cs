using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Status
    {
        [Key]
        public int idStatus { get; set; }
        public string Description { get; set; }
        public string Tipo { get; set; }

    }
}
