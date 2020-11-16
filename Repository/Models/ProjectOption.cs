using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ProjectOption
    {
        [Key]
        public int idProjectOption { get; set; }
        public string Title { get; set; }
        public double PercentDone { get; set; }
    }
}
