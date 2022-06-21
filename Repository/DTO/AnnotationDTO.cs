using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class AnnotationDTO
    {
        public int idAnnotation { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PositionCard { get; set; }
        public int idUser { get; set; }
        public int idProject { get; set; }
        public bool Deleted { get; set; }
        public string ColorBackground { get; set; }
        public string ColorText { get; set; }
        // public List<Attach> Attachments { get; set; }
    }
}
