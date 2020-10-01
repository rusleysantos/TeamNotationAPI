using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface IAttachService
    {
        public Attach AddAttach(Attach attach);
        public bool PutAttach(Attach attach);
        public List<Attach> GetAttachments(int page, int size);
        public Attach GetAttach(int idAttach);
        public bool DeleteAttach(int idAttach);
    }
}
