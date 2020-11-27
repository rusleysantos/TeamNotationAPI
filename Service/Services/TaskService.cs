using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository _repository { get; }
        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public Task<ExecutionTask> AddExecutionTask(ExecutionTask task)
        {
            return _repository.AddExecutionTask(task);
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
