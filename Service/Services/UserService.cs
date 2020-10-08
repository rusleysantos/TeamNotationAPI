using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class UserService: IUserService
    {
        private IUserService _repository { get; }
        public UserService(IUserService repository)
        {
            _repository = repository;
        }

        public User AddUser(User user)
        {
            return _repository.AddUser(user);
        }

        public bool PutUser(User user)
        {
            return _repository.PutUser(user);
        }

        public List<User> GetUsers(int page, int size)
        {
            return _repository.GetUsers(page, size);
        }

        public User GetUser(int idUser)
        {
            return _repository.GetUser(idUser);
        }

        public bool DeleteUser(int idUser)
        {
            return _repository.DeleteUser(idUser);
        }
    }
}
