using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface INotationRepository
    {
        public Task<int> AddNotation(NotationDTO notation);
        public Task<bool> PutNotation(NotationDTO notation);
        public Task<Notation> GetNotation(int idNotation);
        public Task<List<Notation>> GetNotations(int page, int size, int idProject);
        public Task<bool> DeleteNotation(int idNotation);
    }
}
