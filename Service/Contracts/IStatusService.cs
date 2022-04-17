using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Contracts
{
    public interface IStatusService
    {
        public Task<Status> AddStatus(Status backlog);
        public Task<bool> PutStatus(Status backlog);
        public Task<List<Status>> GetStatus(int page, int size);
        public Task<List<Status>> GetStatusAllByType(int page, int size, string type);
        public Task<Status> GetStatus(int idStatus);
        public Task<bool> DeleteStatus(int idStatus);
    }
}
