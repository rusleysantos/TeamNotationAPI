using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IBacklogRepository
    {
        public Backlog AddBacklog(Backlog backlog);
        public bool PutBacklog(Backlog backlog);
        public Backlog GetBacklog(int idBacklog);
        public List<Backlog> GetBacklogs(int page, int size);
        public bool DeleteBacklog(int idBacklog);
    }
}
