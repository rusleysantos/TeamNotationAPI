using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class ExecutionTaskRepository : IExecutionTaskRepository
    {
        private NotationContext _con { get; set; }

        public ExecutionTaskRepository(NotationContext con)
        {
            _con = con;
        }

        public async Task<int> AddExecutionTask(ExecutionTaskDTO task)
        {
            _con.EXECUTION_TASK.Add(new ExecutionTask
            {
                Description = task.Description,
                Effort = task.Effort,
                Weight = task.Weight,
                Title = task.Title,
                idStatus = task.idStatus,
                idUser = task.idUser,
                idProject = task.idProject
                
            });
            await _con.SaveChangesAsync();

            return 0;
        }

        public async Task<bool> DeleteExecutionTask(int idExecutionTask)
        {
            ExecutionTask returnExecutionTask = await _con.EXECUTION_TASK.Where(x => x.idTask == idExecutionTask).FirstAsync();

            if (returnExecutionTask != null)
            {
                _con.Remove(returnExecutionTask);
                await _con.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<ExecutionTask> GetExecutionTask(int idExecutionTask)
        {
            return _con.EXECUTION_TASK.Where(x => x.idTask == idExecutionTask).FirstAsync();
        }

        public async Task<List<ExecutionTask>> GetExecutionTasks(int page, int size)
        {
            return await _con.EXECUTION_TASK
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToListAsync();
        }

        public async Task<List<ExecutionTask>> GetTasksProject(int idProject, int page, int size)
        {
            return await _con.PROJECT
                         .Include(j => j.ExecutionTasks)
                         .Where(x => x.idProject == idProject)
                         .Skip((page - 1) * size)
                         .Take(size)
                         .SelectMany(y => y.ExecutionTasks)
                         .ToListAsync();
        }

        public async Task<bool> PutExecutionTask(ExecutionTaskDTO executionTask)
        {
            Task<ExecutionTask> returnExecutionTask = _con.EXECUTION_TASK.Where(x => x.idTask == executionTask.idTask).FirstAsync();

            if (returnExecutionTask.Result != null)
            {
                //returnExecutionTask.Result.Attachments = executionTask.Attachments.Count == 0 ? returnExecutionTask.Attachments : executionTask.Attachments;
                //returnExecutionTask.Result.Backlogs = executionTask.Backlogs == null ? returnExecutionTask.Backlogs : executionTask.Backlogs;
                returnExecutionTask.Result.Description = executionTask.Description == null ? returnExecutionTask.Result.Description : executionTask.Description;
                returnExecutionTask.Result.Effort = executionTask.Effort == null ? returnExecutionTask.Result.Effort : executionTask.Effort;
                //returnExecutionTa.Resultsk.MainTask = attach.MainTask == null ? returnExecutionTask.MainTask : attach.MainTask;
                returnExecutionTask.Result.idStatus = executionTask.idStatus == returnExecutionTask.Result.idStatus ? returnExecutionTask.Result.idStatus : executionTask.idStatus;
                returnExecutionTask.Result.Title = executionTask.Title == null ? returnExecutionTask.Result.Title : executionTask.Title;
                //returnExecutionTa.Resultsk.User = attach.User == null ? returnExecutionTask.User : attach.User;
                returnExecutionTask.Result.Weight = executionTask.Weight == null ? returnExecutionTask.Result.Weight : executionTask.Weight;

                _con.Update(returnExecutionTask.Result);
                await _con.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }


    }
}


