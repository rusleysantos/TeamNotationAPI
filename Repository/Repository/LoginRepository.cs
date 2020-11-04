using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private NotationContext _con { get; set; }

        public LoginRepository(NotationContext con)
        {
            _con = con;
        }

        public bool Login(Login login)
        {
            if (_con.User.Any(x => x.Login == login.Username && x.Password == login.Password))
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
