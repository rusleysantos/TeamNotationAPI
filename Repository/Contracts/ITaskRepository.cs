using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface ITaskRepository
    {
        public Task AddTask(Task task);
        public bool PutTask(Task task);
        public Task GetTask(int idTask);
        public List<Task> GetTask(int page, int size);
        public bool DeleteTask(int idTask);
    }
}
