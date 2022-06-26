using Repository.Contracts;
using Repository.DTO;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class ExecutionTaskService : IExecutionTaskService
    {
        private IExecutionTaskRepository _repository { get; }
        public ExecutionTaskService(IExecutionTaskRepository repository)
        {
            _repository = repository;
        }

        public Task<int> AddExecutionTask(ExecutionTaskDTO task)
        {
            return _repository.AddExecutionTask(task);
        }

        public Task<bool> PutExecutionTask(ExecutionTaskDTO task)
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

        public Task<bool> PutPositionTask(List<ExecutionTaskDTO> listTask)
        {
            List<ExecutionTask> listTaskParse = new List<ExecutionTask>();

            foreach (var task in listTask)
            {
                listTaskParse.Add(new ExecutionTask
                {
                    idTask = task.idTask,
                    Title = task.Title,
                    Description = task.Description,
                    Weight = task.Weight,
                    Effort = task.Effort,
                    idStatus = task.idStatus,
                    idProject = task.idProject,
                    idUser = task.idUser,
                    SequenceNumber = listTask.IndexOf(task),
                    ColorBackground = task.ColorBackground,
                    ColorText = task.ColorText
                });
            }

            return _repository.PutPositionTask(listTaskParse);
        }
    }
}
