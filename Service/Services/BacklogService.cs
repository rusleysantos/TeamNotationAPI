using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BacklogService : IBacklogService
    {
        private IBacklogService _repository { get; }
        public BacklogService(IBacklogService repository)
        {
            _repository = repository;
        }




    }
}
