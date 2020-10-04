using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class TaskRepository : ITaskRepository
    {
        private NotationContext _con { get; set; }

        public TaskRepository(NotationContext con)
        {
            _con = con;
        }

        public ExecutionTask AddExecutionTask(ExecutionTask attach)
        {
            _con.Add(attach);
            _con.SaveChanges();

            return attach;
        }

        public bool DeleteExecutionTask(int idExecutionTask)
        {
            ExecutionTask returnExecutionTask = _con.Task.Where(x => x.idTask == idExecutionTask).First();

            if (returnExecutionTask != null)
            {
                _con.Remove(returnExecutionTask);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public ExecutionTask GetExecutionTask(int idExecutionTask)
        {
            return _con.Task.Where(x => x.idTask == idExecutionTask).First();
        }

        public List<ExecutionTask> GetExecutionTasks(int page, int size)
        {
            return _con.Task
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutExecutionTask(ExecutionTask attach)
        {
            ExecutionTask returnExecutionTask = _con.Task.Where(x => x.idTask == attach.idTask).First();

            if (returnExecutionTask != null)
            {
                returnExecutionTask.Attachments = attach.Attachments.Count == 0 ? returnExecutionTask.Attachments : attach.Attachments;
                returnExecutionTask.Backlogs = attach.Backlogs == null ? returnExecutionTask.Backlogs : attach.Backlogs;
                returnExecutionTask.Description = attach.Description == null ? returnExecutionTask.Description : attach.Description;
                returnExecutionTask.Effort = attach.Effort == null ? returnExecutionTask.Effort : attach.Effort;
                returnExecutionTask.MainTask = attach.MainTask == null ? returnExecutionTask.MainTask : attach.MainTask;
                returnExecutionTask.Status = attach.Status == null ? returnExecutionTask.Status : attach.Status;
                returnExecutionTask.Title = attach.Title == null ? returnExecutionTask.Title : attach.Title;
                returnExecutionTask.User = attach.User == null ? returnExecutionTask.User : attach.User;
                returnExecutionTask.Weight = attach.Weight == null ? returnExecutionTask.Weight : attach.Weight;

                _con.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


