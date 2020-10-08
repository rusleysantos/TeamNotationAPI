using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
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

        public Notation AddNotation(Notation notation)
        {
            return _repository.AddNotation(notation);
        }

        public bool PutNotation(Notation notation)
        {
            return _repository.PutNotation(notation);
        }

        public List<Notation> GetNotations(int page, int size)
        {
            return _repository.GetNotations(page, size);
        }

        public Notation GetNotation(int idNotation)
        {
            return _repository.GetNotation(idNotation);
        }

        public bool DeleteNotation(int idNotation)
        {
            return _repository.DeleteNotation(idNotation);
        }
    }
}
