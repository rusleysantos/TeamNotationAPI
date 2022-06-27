using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<User> AddUser(User user)
        {
            await _con.AddAsync(user);
            await _con.SaveChangesAsync();

            return user;
        }

        public async Task<bool> DeleteUser(int idUser)
        {
            User returnUser = await _con.USER.Where(x => x.idUser == idUser).FirstAsync();

            if (returnUser != null)
            {
                _con.Remove(returnUser);
                await _con.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<User> GetUser(int idUser)
        {
            return await _con.USER.Where(x => x.idUser == idUser).FirstAsync();
        }

        public async Task<List<User>> GetUsers(int page, int size)
        {
            return await _con.USER
                        .Skip((page - 1) * size)
                        .Take(size)
                        .Select(x => new User
                        {
                            idUser = x.idUser,
                            Login = x.Login,
                            Password = ""
                        })
                        .ToListAsync();
        }

        public async Task<bool> PutUser(User user)
        {
            User returnUser = await _con.USER.Where(x => x.idUser == user.idUser).FirstAsync();

            if (returnUser != null)
            {
                //returnUser.Address = user.Address == null ? returnUser.Address : user.Address;
                //returnUser.Login = user.Login == null ? returnUser.Login : user.Login;
                //returnUser.Password = user.Password == null ? returnUser.Password : user.Password;
                //returnUser.Profile = user.Profile == null ? returnUser.Profile : user.Profile;

                await _con.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

