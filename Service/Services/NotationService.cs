using Repository.Contracts;
using Repository.DTO;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class NotationService: INotationService
    {
        private INotationRepository _repository { get; }
        public NotationService(INotationRepository repository)
        {
            _repository = repository;
        }

        public Task<int> AddNotation(NotationDTO notation)
        {
            return _repository.AddNotation(notation);
        }

        public Task<bool> PutNotation(NotationDTO notation)
        {
            return _repository.PutNotation(notation);
        }

        public Task<List<Notation>> GetNotations(int page, int size, int idProject)
        {
            return _repository.GetNotations(page, size, idProject);
        }

        public Task<Notation> GetNotation(int idNotation)
        {
            return _repository.GetNotation(idNotation);
        }

        public Task<bool> DeleteNotation(int idNotation)
        {
            return _repository.DeleteNotation(idNotation);
        }
    }
}
