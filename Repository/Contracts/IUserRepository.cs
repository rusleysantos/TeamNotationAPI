using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        public User AddUser(User user);
        public bool PutUser(User user);
        public User GetUser(int idUser);
        public List<User> GetUser(int page, int size);
        public bool DeleteUser(int idUser);
    }
}
