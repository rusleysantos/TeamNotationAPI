using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Models
{
    public class Sprint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_SPRINT")]
        public int idSprint { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("GOAL")]
        public string Goal { get; set; }

        [Column("START")]
        public DateTime Start { get; set; }

        [Column("END")]
        public DateTime End { get; set; }

        [Column("EXECUTORS")]
        public List<User> Executors { get; set; }
    }
}
