using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IStatusRepository
    {
        public Status AddStatus(Status statusBacklog);
        public bool PutStatus(Status statusBacklog);
        public Status GetStatus(int idStatus);
        public List<Status> GetStatus(int page, int size);
        public bool DeleteStatus(int idStatus);
    }
}
