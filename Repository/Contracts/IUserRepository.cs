using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        public User AddUser(User user);
        public bool PutUser(User user);
        public User GetUser(int idUser);
        public List<User> GetUsers(int page, int size);
        public bool DeleteUser(int idUser);
    }
}
