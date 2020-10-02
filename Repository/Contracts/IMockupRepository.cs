using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IMockupRepository
    {
        public Mockup AddMockup(Mockup mockup);
        public bool PutMockup(Mockup mockup);
        public Mockup GetMockup(int idMockup);
        public List<Mockup> GetMockup(int page, int size);
        public bool DeleteMockup(int idMockup);
    }
}
