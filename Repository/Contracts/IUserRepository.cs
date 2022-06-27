using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        public Task<User> AddUser(User user);
        public Task<bool> PutUser(User user);
        public Task<User> GetUser(int idUser);
        public Task<List<User>> GetUsers(int page, int size);
        public Task<bool> DeleteUser(int idUser);
    }
}
