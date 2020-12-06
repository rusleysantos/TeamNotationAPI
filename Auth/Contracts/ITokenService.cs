using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Contracts
{
    public interface ITokenService
    {
        public string GenerateToken(LoginDTO login);
    }
}
