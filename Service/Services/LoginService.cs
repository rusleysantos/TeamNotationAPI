using Repository.Contracts;
using Repository.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private ILoginRepository _repository { get; }

        public LoginService(ILoginRepository repository)
        {
            _repository = repository;
        }

        public bool Login(Login login)
        {
            return _repository.Login(login);
        }
    }
}
