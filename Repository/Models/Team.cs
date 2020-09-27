﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class Team
    {
        [Key]
        public int idTeam { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
