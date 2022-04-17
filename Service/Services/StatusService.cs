using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class StatusService : IStatusService
    {
        private IStatusRepository _repository { get; }
        public StatusService(IStatusRepository repository)
        {
            _repository = repository;
        }

        public Task<Status> AddStatus(Status status)
        {
            return _repository.AddStatus(status);
        }

        public Task<bool> PutStatus(Status impediment)
        {
            return _repository.PutStatus(impediment);
        }

        public Task<List<Status>> GetStatus(int page, int size)
        {
            return _repository.GetStatus(page, size);
        }

        public Task<List<Status>> GetStatusAllByType(int page, int size, string type)
        {
            return _repository.GetStatusAllByType(page, size, type);
        }

        public Task<Status> GetStatus(int idStatus)
        {
            return _repository.GetStatus(idStatus);
        }

        public Task<bool> DeleteStatus(int idStatus)
        {
            return _repository.DeleteStatus(idStatus);
        }
    }
}
