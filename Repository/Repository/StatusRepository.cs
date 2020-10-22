using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class StatusRepository : IStatusRepository
    {
        private NotationContext _con { get; set; }

        public StatusRepository(NotationContext con)
        {
            _con = con;
        }

        public Status AddStatus(Status status)
        {
            _con.Add(status);
            _con.SaveChanges();

            return status;
        }

        public bool DeleteStatus(int idStatus)
        {
            Status returnStatus = _con.Status.Where(x => x.idStatus == idStatus).First();

            if (returnStatus != null)
            {
                _con.Remove(returnStatus);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Status GetStatus(int idStatus)
        {
            return _con.Status.Where(x => x.idStatus == idStatus).First();
        }

        public List<Status> GetStatus(int page, int size)
        {
            return _con.Status
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutStatus(Status attach)
        {
            Status returnStatus = _con.Status.Where(x => x.idStatus == attach.idStatus).First();

            if (returnStatus != null)
            {
                returnStatus.Description = attach.Description == string.Empty ? returnStatus.Description : attach.Description;
                returnStatus.Tipo = attach.Tipo == string.Empty ? returnStatus.Tipo : attach.Tipo;

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
