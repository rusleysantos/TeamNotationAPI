using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Contracts
{
    public interface IAttachRepository
    {
        public Attach AddAttach(Attach attach);
        public bool PutAttach(Attach attach);
        public Attach GetAttach(int idAttach);
        public List<Attach> GetAttachments(int page, int size);
        public bool DeleteAttach(int idAttach);
    }
}
