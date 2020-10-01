using Repository.Contracts;
using Service.Contracts;
using System.Collections.Generic;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class AttachService : IAttachService
    {
        private IAttachRepository _repository { get; }
        public AttachService(IAttachRepository repository)
        {
            _repository = repository;
        }

        public Attach AddAttach(Attach attach)
        {
            return _repository.AddAttach(attach);
        }

        public bool DeleteAttach(int idAttach)
        {
            return _repository.DeleteAttach(idAttach); ;
        }

        public Attach GetAttach(int idAttach)
        {
            return _repository.GetAttach(idAttach);
        }

        public List<Attach> GetAttachments(int page, int size)
        {
            return _repository.GetAttachments(page, size);
        }

        public bool PutAttach(Attach attach)
        {
            return _repository.PutAttach(attach);
        }
    }
}
