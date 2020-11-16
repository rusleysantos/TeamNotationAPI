using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private NotationContext _con { get; set; }

        public LoginRepository(NotationContext con)
        {
            _con = con;
        }

        public async Task<Login> Login(Login login)
        {

            Login loginReturn = _con
                                .User
                                .Where(x => x.Login == login.Username
                                       &&
                                       x.Password == login.Password)
                                .Select(x => new Login
                                {
                                    idUser = x.idUser,
                                    Username = login.Username
                                }).FirstAsync()
                                .Result;

            if (loginReturn != null)
            {
                loginReturn.AuthorizationStatus = true;
                return loginReturn;
            }
            else
            {
                loginReturn.AuthorizationStatus = false;
                return loginReturn;
            }

        }
    }
}
