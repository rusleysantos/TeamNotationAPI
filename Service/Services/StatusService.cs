using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class StatusService: IStatusService
    {
        private IStatusRepository _repository { get; }
        public StatusService(IStatusRepository repository)
        {
            _repository = repository;
        }

        public Status AddStatus(Status status)
        {
            return _repository.AddStatus(status);
        }

        public bool PutStatus(Status impediment)
        {
            return _repository.PutStatus(impediment);
        }

        public List<Status> GetStatus(int page, int size)
        {
            return _repository.GetStatus(page, size);
        }

        public Status GetStatus(int idStatus)
        {
            return _repository.GetStatus(idStatus);
        }

        public bool DeleteStatus(int idStatus)
        {
            return _repository.DeleteStatus(idStatus);
        }
    }
}
