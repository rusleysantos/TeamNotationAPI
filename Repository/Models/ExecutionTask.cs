using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNotationAPI.Models
{
    public class ExecutionTask
    {
        [Key]
        public int idTask { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Effort { get; set; }
        public List<Backlog> Backlogs { get; set; }
        public List<Attach> Attachments { get; set; }

        [ForeignKey("FK_Task_Status_StatusidStatus")]
        public int StatusidStatus { get; set; }
        public Status Status { get; set; }

        //[ForeignKey("FK_Task_Task_MainTaskidTask")]
        //public int MainTaskidTask { get; set; }
        public ExecutionTask MainTask { get; set; }

        [ForeignKey("FK_Task_User_UseridUser")]
        public int UseridUser { get; set; }
        public User User { get; set; }

        [ForeignKey("FK_Task_Project_ProjectidProject")]
        public int ProjectidProject { get; set; }

    }
}
