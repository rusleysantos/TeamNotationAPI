using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Repository.Services
{
    public class ExecutionTaskRepository : IExecutionTaskRepository
    {
        private AnnotationContext _con { get; set; }

        public ExecutionTaskRepository(AnnotationContext con)
        {
            _con = con;
        }

        public async Task<int> AddExecutionTask(ExecutionTaskDTO task)
        {

            var taskSequence = await _con.EXECUTION_TASK
                                            .Where(x => x.idProject == task.idProject)
                                            .OrderByDescending(j => j.SequenceNumber)
                                            .Select(x => new { x.SequenceNumber })
                                            .FirstOrDefaultAsync();

            _con.EXECUTION_TASK.Add(new ExecutionTask
            {
                Description = task.Description,
                Effort = task.Effort,
                Weight = task.Weight,
                Title = task.Title,
                idStatus = task.idStatus,
                idUser = task.idUser,
                idProject = task.idProject,
                SequenceNumber = taskSequence == null ? 0 : taskSequence.SequenceNumber + 1,
                ColorBackground = task.ColorBackground,
                ColorText = task.ColorText

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

        public async Task<ExecutionTask> GetExecutionTask(int idExecutionTask)
        {
            return await _con.EXECUTION_TASK
                    .Include(j => j.Status)
                    .Where(x => x.idTask == idExecutionTask)
                    .FirstAsync();
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
                            .ThenInclude(x => x.Status)
                         .Where(x => x.idProject == idProject)
                         .Skip((page - 1) * size)
                         .Take(size)
                         .SelectMany(y => y.ExecutionTasks)
                         .OrderBy(o => o.SequenceNumber)
                         .ToListAsync();
        }

        public async Task<bool> PutExecutionTask(ExecutionTaskDTO executionTask)
        {
            ExecutionTask returnExecutionTask = _con.EXECUTION_TASK.Where(x => x.idTask == executionTask.idTask).First();
            Status status = _con.STATUS.Where(x => x.idStatus == executionTask.idStatus).First();

            if (status.Description == "Excluir")
            {
                _con.Remove(returnExecutionTask);
                _con.SaveChanges();

                return true;
            }

            if (returnExecutionTask != null)
            {
                //returnExecutionTask.Result.Attachments = executionTask.Attachments.Count == 0 ? returnExecutionTask.Attachments : executionTask.Attachments;
                //returnExecutionTask.Result.Backlogs = executionTask.Backlogs == null ? returnExecutionTask.Backlogs : executionTask.Backlogs;
                returnExecutionTask.Description = executionTask.Description == null ? returnExecutionTask.Description : executionTask.Description;
                returnExecutionTask.Effort = executionTask.Effort == null ? returnExecutionTask.Effort : executionTask.Effort;
                //returnExecutionTa.Resultsk.MainTask = attach.MainTask == null ? returnExecutionTask.MainTask : attach.MainTask;
                returnExecutionTask.idStatus = executionTask.idStatus == returnExecutionTask.idStatus ? returnExecutionTask.idStatus : executionTask.idStatus;
                returnExecutionTask.Title = executionTask.Title == null ? returnExecutionTask.Title : executionTask.Title;
                //returnExecutionTa.Resultsk.User = attach.User == null ? returnExecutionTask.User : attach.User;
                returnExecutionTask.Weight = executionTask.Weight == null ? returnExecutionTask.Weight : executionTask.Weight;
                returnExecutionTask.ColorBackground = executionTask.ColorBackground == null ? returnExecutionTask.ColorBackground : executionTask.ColorBackground;
                returnExecutionTask.ColorText = executionTask.ColorText == null ? returnExecutionTask.ColorText : executionTask.ColorText;


                _con.Update(returnExecutionTask);
                await _con.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> PutPositionTask(List<ExecutionTask> listTask)
        {

            try
            {
                _con.EXECUTION_TASK
                    .UpdateRange(listTask);

                await _con.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }

            //var listTasks = await _con.EXECUTION_TASK
            //                        .Where(x => x.idTask == idPositionTaskPrevious ||
            //                                    x.idTask == idPositionTaskCurrent)
            //                        .ToListAsync();

            //var task = listTasks[0].SequenceNumber;
            //listTasks[0].SequenceNumber = listTasks[1].SequenceNumber;
            //listTasks[1].SequenceNumber = task;

            //_con.UpdateRange(listTasks);

            //await _con.SaveChangesAsync();

            //return await _con.PROJECT
            //          .Include(j => j.ExecutionTasks)
            //             .ThenInclude(x => x.Status)
            //          .Where(x => x.idProject == listTasks[0].idProject)
            //          .Skip((page - 1) * size)
            //          .Take(size)
            //          .SelectMany(y => y.ExecutionTasks)
            //          .OrderBy(o => o.SequenceNumber)
            //          .ToListAsync();
        }

    }
}


