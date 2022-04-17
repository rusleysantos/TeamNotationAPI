using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Contracts
{
    public interface IMockupService
    {
        public Mockup AddMockup(Mockup mockup);
        public bool PutMockup(Mockup mockup);
        public List<Mockup> GetMockups(int page, int size);
        public Mockup GetMockup(int idMockup);
        public bool DeleteMockup(int idMockup);
    }
}
