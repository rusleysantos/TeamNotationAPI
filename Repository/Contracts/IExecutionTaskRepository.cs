using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IExecutionTaskRepository
    {
        public Task<int> AddExecutionTask(ExecutionTaskDTO task);
        public Task<bool> DeleteExecutionTask(int idTask);
        public Task<List<ExecutionTask>> GetExecutionTasks(int page, int size);
        Task<List<ExecutionTask>> GetTasksProject(int idProject, int page, int size);
        public Task<ExecutionTask> GetExecutionTask(int idTask);
        public Task<bool> PutExecutionTask(ExecutionTask task);
    }
}
