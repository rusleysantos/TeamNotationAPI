using Repository.Contracts;
using Repository.DTO;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class ExecutionTaskService : IExecutionTaskService
    {
        private IExecutionTaskRepository _repository { get; }
        public ExecutionTaskService(IExecutionTaskRepository repository)
        {
            _repository = repository;
        }

        public void AddExecutionTask(ExecutionTaskDTO task)
        {
            _repository.AddExecutionTask(task);
        }

        public Task<bool> PutExecutionTask(ExecutionTask task)
        {
            return _repository.PutExecutionTask(task);
        }

        public Task<List<ExecutionTask>> GetExecutionTasks(int page, int size)
        {
            return _repository.GetExecutionTasks(page, size);
        }

        public Task<List<ExecutionTask>> GetTasksProject(int idProject, int page, int size)
        {
            return _repository.GetTasksProject(idProject, page, size);
        }

        public Task<ExecutionTask> GetExecutionTask(int idTask)
        {
            return _repository.GetExecutionTask(idTask);
        }

        public Task<bool> DeleteExecutionTask(int idTask)
        {
            return _repository.DeleteExecutionTask(idTask);
        }
    }
}
