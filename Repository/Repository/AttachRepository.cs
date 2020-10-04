using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class AttachRepository : IAttachRepository
    {
        private NotationContext _con { get; set; }

        public AttachRepository(NotationContext con)
        {
            _con = con;
        }

        public Attach AddAttach(Attach attach)
        {
            _con.Add(attach);
            _con.SaveChanges();

            return attach;
        }

        public bool DeleteAttach(int idAttach)
        {
            Attach returnAttach = _con.AttachT.Where(x => x.idAttach == idAttach).First();

            if (returnAttach != null)
            {
                _con.Remove(returnAttach);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Attach GetAttach(int idAttach)
        {
            return _con.AttachT.Where(x => x.idAttach == idAttach).First();
        }

        public List<Attach> GetAttachments(int page, int size)
        {
            return _con.AttachT
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutAttach(Attach attach)
        {
            Attach returnAttach = _con.AttachT.Where(x => x.idAttach == attach.idAttach).First();

            if (returnAttach != null)
            {
                returnAttach.Blob = attach.Blob == 0 ? returnAttach.Blob : attach.Blob;
                returnAttach.Title = attach.Title == null ? returnAttach.Title : attach.Title;
                returnAttach.Type = attach.Type == null ? returnAttach.Type : attach.Type;

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
