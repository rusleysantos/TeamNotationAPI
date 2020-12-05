using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface INotationRepository
    {
        public Task<Notation> AddNotation(Notation notation);
        public Task<bool> PutNotation(Notation notation);
        public Task<Notation> GetNotation(int idNotation);
        public Task<List<Notation>> GetNotations(int page, int size);
        public Task<bool> DeleteNotation(int idNotation);
    }
}
