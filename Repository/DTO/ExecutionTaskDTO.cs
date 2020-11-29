﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class ExecutionTaskDTO
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int Effort { get; set; }
        public int idStatus { get; set; }
        public int idMainTask { get; set; }
        public int idProject { get; set; }
        // public List<int> idsBacklogs { get; set; }
        public int idUser { get; set; }
        // public List<int> idsAttachments { get; set; }
    }
}