using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Address
    {
        [Key]
        public int idAddress { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Countrie { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
