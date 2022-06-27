using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Contracts
{
    public interface IUserService
    {
        public Task<User> AddUser(User backlog);
        public Task<bool> PutUser(User backlog);
        public Task<List<User>> GetUsers(int page, int size);
        public Task<User> GetUser(int idUser);
        public Task<bool> DeleteUser(int idUser);
    }
}
