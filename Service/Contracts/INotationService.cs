using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface INotationService
    {
        public Task<Notation> AddNotation(Notation notations);
        public Task<bool> PutNotation(Notation notations);
        public Task<List<Notation>> GetNotations(int page, int size);
        public Task<Notation> GetNotation(int idNotation);
        public Task<bool> DeleteNotation(int idNotation);
    }
}
