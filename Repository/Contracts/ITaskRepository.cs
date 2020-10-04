using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface ITaskRepository
    {
        public ExecutionTask AddExecutionTask(ExecutionTask task);
        public bool DeleteExecutionTask(int idTask);
        public List<ExecutionTask> GetExecutionTasks(int page, int size);
        public ExecutionTask GetExecutionTask(int idTask);
        public bool PutExecutionTask(ExecutionTask task);
    }
}
