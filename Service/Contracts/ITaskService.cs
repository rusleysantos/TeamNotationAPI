using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ITaskService
    {
        public Task AddTask(Task task);
        public bool PutTask(Task task);
        public List<Task> GetTasks(int page, int size);
        public Task GetTask(int idTask);
        public bool DeleteTask(int idTask);
    }
}
