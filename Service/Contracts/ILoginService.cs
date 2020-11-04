using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface ILoginService
    {
        public bool Login(Login login);
    }
}
