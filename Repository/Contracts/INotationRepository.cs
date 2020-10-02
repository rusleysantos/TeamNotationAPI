using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface INotationRepository
    {
        public Notation AddNotation(Notation notation);
        public bool PutNotation(Notation notation);
        public Notation GetNotation(int idNotation);
        public List<Notation> GetNotation(int page, int size);
        public bool DeleteNotation(int idNotation);
    }
}
