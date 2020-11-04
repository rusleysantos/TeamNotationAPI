using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface ILoginRepository
    {
        public bool Login(Login login);
    }
}
