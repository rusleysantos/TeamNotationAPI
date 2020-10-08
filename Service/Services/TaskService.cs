using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TaskService: ITaskService
    {
        private ITaskService _repository { get; }
        public TaskService(ITaskService repository)
        {
            _repository = repository;
        }

        public Task AddTask(Task task)
        {
            return _repository.AddTask(task);
        }

        public bool PutTask(Task task)
        {
            return _repository.PutTask(task);
        }

        public List<Task> GetTasks(int page, int size)
        {
            return _repository.GetTasks(page, size);
        }

        public Task GetTask(int idTask)
        {
            return _repository.GetTask(idTask);
        }

        public bool DeleteTask(int idTask)
        {
            return _repository.DeleteTask(idTask);
        }
    }
}
