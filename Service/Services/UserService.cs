using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class UserService: IUserService
    {
        private IUserRepository _repository { get; }
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<User> AddUser(User user)
        {
            return _repository.AddUser(user);
        }

        public Task<bool> PutUser(User user)
        {
            return _repository.PutUser(user);
        }

        public Task<List<User>> GetUsers(int page, int size)
        {
            return _repository.GetUsers(page, size);
        }

        public Task<User> GetUser(int idUser)
        {
            return _repository.GetUser(idUser);
        }

        public Task<bool> DeleteUser(int idUser)
        {
            return _repository.DeleteUser(idUser);
        }
    }
}
