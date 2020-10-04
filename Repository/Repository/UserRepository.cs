using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class UserRepository : IUserRepository
    {
        private NotationContext _con { get; set; }

        public UserRepository(NotationContext con)
        {
            _con = con;
        }

        public User AddUser(User attach)
        {
            _con.Add(attach);
            _con.SaveChanges();

            return attach;
        }

        public bool DeleteUser(int idUser)
        {
            User returnUser = _con.User.Where(x => x.idUser == idUser).First();

            if (returnUser != null)
            {
                _con.Remove(returnUser);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUser(int idUser)
        {
            return _con.User.Where(x => x.idUser == idUser).First();
        }

        public List<User> GetUsers(int page, int size)
        {
            return _con.User
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutUser(User attach)
        {
            User returnUser = _con.User.Where(x => x.idUser == attach.idUser).First();

            if (returnUser != null)
            {
                returnUser.Address = attach.Address == null ? returnUser.Address : attach.Address;
                returnUser.Login = attach.Login == null ? returnUser.Login : attach.Login;
                returnUser.Password = attach.Password == null ? returnUser.Password : attach.Password;
                returnUser.Profile = attach.Profile == null ? returnUser.Profile : attach.Profile;

                _con.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

