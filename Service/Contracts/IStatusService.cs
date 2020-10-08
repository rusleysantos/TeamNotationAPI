using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface IStatusService
    {
        public Status AddStatus(Status backlog);
        public bool PutStatus(Status backlog);
        public List<Status> GetStatus(int page, int size);
        public Status GetStatus(int idStatus);
        public bool DeleteStatus(int idStatus);
    }
}
