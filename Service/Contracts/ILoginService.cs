﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ILoginService
    {
        Task<bool> Login(Login login);
    }
}
