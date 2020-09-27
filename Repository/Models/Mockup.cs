using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Mockup
    {
        [Key]
        public int idMockup { get; set; }
        public string Type { get; set; }
        public byte Blob { get; set; }
    }
}
