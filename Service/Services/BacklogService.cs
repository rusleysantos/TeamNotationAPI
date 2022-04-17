using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class BacklogService : IBacklogService
    {
        private IBacklogService _repository { get; }
        public BacklogService(IBacklogService repository)
        {
            _repository = repository;
        }

        public Backlog AddBacklog(Backlog backlog)
        {
            return _repository.AddBacklog(backlog);
        }

        public bool PutBacklog(Backlog backlog)
        {
            return _repository.PutBacklog(backlog);
        }

        public List<Backlog> GetBacklog(int page, int size)
        {
            return _repository.GetBacklog(page, size);
        }

        public Backlog GetBacklog(int idBacklog)
        {
            return _repository.GetBacklog(idBacklog);
        }

        public bool DeleteBacklog(int idBacklog)
        {
            return _repository.DeleteBacklog(idBacklog);
        }
    }
}
