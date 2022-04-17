using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Services
{
    public class UserRepository : IUserRepository
    {
        private AnnotationContext _con { get; set; }

        public UserRepository(AnnotationContext con)
        {
            _con = con;
        }

        public User AddUser(User user)
        {
            _con.Add(user);
            _con.SaveChanges();

            return user;
        }

        public bool DeleteUser(int idUser)
        {
            User returnUser = _con.USER.Where(x => x.idUser == idUser).First();

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
            return _con.USER.Where(x => x.idUser == idUser).First();
        }

        public List<User> GetUsers(int page, int size)
        {
            return _con.USER
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutUser(User user)
        {
            User returnUser = _con.USER.Where(x => x.idUser == user.idUser).First();

            if (returnUser != null)
            {
                //returnUser.Address = user.Address == null ? returnUser.Address : user.Address;
                //returnUser.Login = user.Login == null ? returnUser.Login : user.Login;
                //returnUser.Password = user.Password == null ? returnUser.Password : user.Password;
                //returnUser.Profile = user.Profile == null ? returnUser.Profile : user.Profile;

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

