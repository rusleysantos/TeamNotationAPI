using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IStatusRepository
    {
        public StatusBacklog AddStatusBacklog(StatusBacklog statusBacklog);
        public bool PutStatusBacklog(StatusBacklog statusBacklog);
        public StatusBacklog GetStatusBacklog(int idStatus);
        public List<StatusBacklog> GetStatusBacklog(int page, int size);
        public bool DeleteStatusBacklog(int idStatus);

        public StatusTask AddStatusTask(StatusTask statusTask);
        public bool PutStatusTasks(StatusTask statusTask);
        public StatusTask GetStatusTask(int idStatus);
        public List<StatusTask> GetStatusTask(int page, int size);
        public bool DeleteStatusTask(int idStatus);
    }
}
