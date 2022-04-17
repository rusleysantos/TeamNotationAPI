using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Contracts
{
    public interface IUserService
    {
        public User AddUser(User backlog);
        public bool PutUser(User backlog);
        public List<User> GetUsers(int page, int size);
        public User GetUser(int idUser);
        public bool DeleteUser(int idUser);
    }
}
