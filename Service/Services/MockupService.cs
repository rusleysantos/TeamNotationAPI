using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class MockupService: IMockupService
    {
        private IMockupService _repository { get; }
        public MockupService(IMockupService repository)
        {
            _repository = repository;
        }

        public Mockup AddMockup(Mockup mockup)
        {
            return _repository.AddMockup(mockup);
        }

        public bool PutMockup(Mockup mockup)
        {
            return _repository.PutMockup(mockup);
        }

        public List<Mockup> GetMockups(int page, int size)
        {
            return _repository.GetMockups(page, size);
        }

        public Mockup GetMockup(int idMockup)
        {
            return _repository.GetMockup(idMockup);
        }

        public bool DeleteMockup(int idMockup)
        {
            return _repository.DeleteMockup(idMockup);
        }
    }
}
