using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int idUser { get; set; }
        public bool AuthorizationStatus { get; set; }
    }
}
