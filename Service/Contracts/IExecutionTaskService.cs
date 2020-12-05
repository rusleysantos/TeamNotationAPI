using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface IExecutionTaskService
    {
        public Task<int> AddExecutionTask(ExecutionTaskDTO task);
        public Task<bool> PutExecutionTask(ExecutionTask task);
        public Task<List<ExecutionTask>> GetExecutionTasks(int page, int size);
        public Task<List<ExecutionTask>> GetTasksProject(int idProject, int page, int size);
        public Task<ExecutionTask> GetExecutionTask(int idTask);
        public Task<bool> DeleteExecutionTask(int idTask);
    }
}
