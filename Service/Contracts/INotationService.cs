using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface INotationService
    {
        public Task<int> AddNotation(NotationDTO notations);
        public Task<bool> PutNotation(NotationDTO notations);
        public Task<List<Notation>> GetNotations(int page, int size, int idProject);
        public Task<Notation> GetNotation(int idNotation);
        public Task<bool> DeleteNotation(int idNotation);
    }
}
