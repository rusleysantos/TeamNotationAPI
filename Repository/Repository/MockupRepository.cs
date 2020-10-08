using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class MockupRepository : IMockupRepository
    {
        private NotationContext _con { get; set; }

        public MockupRepository(NotationContext con)
        {
            _con = con;
        }

        public Mockup AddMockup(Mockup mockup)
        {
            _con.Add(mockup);
            _con.SaveChanges();

            return mockup;
        }

        public bool DeleteMockup(int idMockup)
        {
            Mockup returnMockup = _con.Mockup.Where(x => x.idMockup == idMockup).First();

            if (returnMockup != null)
            {
                _con.Remove(returnMockup);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Mockup GetMockup(int idMockup)
        {
            return _con.Mockup.Where(x => x.idMockup == idMockup).First();
        }

        public List<Mockup> GetMockups(int page, int size)
        {
            return _con.Mockup
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutMockup(Mockup mockup)
        {
            Mockup returnMockup = _con.Mockup.Where(x => x.idMockup == mockup.idMockup).First();

            if (returnMockup != null)
            {
                returnMockup.Blob = mockup.Blob == 0 ? returnMockup.Blob : mockup.Blob;
                returnMockup.Type = mockup.Type == null ? returnMockup.Type : mockup.Type;

                _con.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
