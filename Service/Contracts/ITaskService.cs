using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface ITaskService
    {
        public Task<ExecutionTask> AddExecutionTask(ExecutionTask task);
        public Task<bool> PutExecutionTask(ExecutionTask task);
        public Task<List<ExecutionTask>> GetExecutionTasks(int page, int size);
        public Task<List<ExecutionTask>> GetTasksProject(int idProject, int page, int size);
        public Task<ExecutionTask> GetExecutionTask(int idTask);
        public Task<bool> DeleteExecutionTask(int idTask);
    }
}
