using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class NotationDTO
    {
        public int idNotation { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PositionCard { get; set; }
        public int idUser { get; set; }
        public int idProject { get; set; }
       // public List<Attach> Attachments { get; set; }
    }
}
