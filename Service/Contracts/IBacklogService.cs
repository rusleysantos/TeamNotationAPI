using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface IBacklogService
    {
        public Backlog AddBacklog(Backlog backlog);
        public bool PutBacklog(Backlog backlog);
        public List<Backlog> GetBacklog(int page, int size);
        public Backlog GetBacklog(int idBacklog);
        public bool DeleteBacklog(int idBacklog);
    }
}
