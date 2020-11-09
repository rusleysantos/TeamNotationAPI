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

        public async Task<bool> Login(Login login)
        {
            if (await _con.User.AnyAsync(x => x.Login == login.Username && x.Password == login.Password))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
