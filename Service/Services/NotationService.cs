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
        private INotationService _repository { get; }
        public NotationService(INotationService repository)
        {
            _repository = repository;
        }

        public Task<Notation> AddNotation(Notation notation)
        {
            return _repository.AddNotation(notation);
        }

        public Task<bool> PutNotation(Notation notation)
        {
            return _repository.PutNotation(notation);
        }

        public Task<List<Notation>> GetNotations(int page, int size)
        {
            return _repository.GetNotations(page, size);
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
