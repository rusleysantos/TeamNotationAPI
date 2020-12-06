using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.DTO;
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

        public async Task<LoginDTO> Login(LoginDTO login)
        {

            LoginDTO loginReturn = _con
                                .User
                                .Where(x => x.Login == login.Username
                                       &&
                                       x.Password == login.Password)
                                .Select(x => new LoginDTO
                                {
                                    idUser = x.idUser,
                                    Username = login.Username
                                }).FirstOrDefault();
                               

            if (loginReturn != null)
            {
                loginReturn.AuthorizationStatus = true;
                return loginReturn;
            }
            else
            {
                login.AuthorizationStatus = false;
                return login;
            }

        }
    }
}
