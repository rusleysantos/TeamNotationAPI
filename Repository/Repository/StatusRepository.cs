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
        //private NotationContext _con { get; set; }

        //public StatusRepository(NotationContext con)
        //{
        //    _con = con;
        //}

        //public StatusBacklog AddStatus(StatusBacklog statusBacklog)
        //{
        //    _con.Add(statusBacklog);
        //    _con.SaveChanges();

        //    return statusBacklog;
        //}

        //public bool DeleteStatus(int idStatus)
        //{
        //    StatusBacklog returnMockup = _con.StatusBacklog.Where(x => x.idStatusBacklog == idStatus).First();

        //    if (returnMockup != null)
        //    {
        //        _con.Remove(returnMockup);
        //        _con.SaveChanges();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public StatusBacklog GetStatusBacklog(int idStatus)
        //{
        //    return _con.StatusBacklog.Where(x => x.idMockup == idStatus).First();
        //}

        //public List<Status> GetStatusTask(int page, int size)
        //{
        //    return _con.Mockup
        //             .Skip((page - 1) * size)
        //             .Take(size)
        //             .ToList();
        //}

        //public bool PutStatusTasks(Status statusTask)
        //{
        //    Mockup returnMockup = _con.Mockup.Where(x => x.idMockup == attach.idMockup).First();

        //    if (returnMockup != null)
        //    {
        //        returnMockup.Blob = attach.Blob == 0 ? returnMockup.Blob : attach.Blob;
        //        returnMockup.Title = attach.Title == null ? returnMockup.Title : attach.Title;
        //        returnMockup.Type = attach.Type == null ? returnMockup.Type : attach.Type;

        //        _con.SaveChanges();

        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public Status AddStatus(Status statusBacklog)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStatus(int idStatus)
        {
            throw new NotImplementedException();
        }

        public Status GetStatus(int idStatus)
        {
            throw new NotImplementedException();
        }

        public List<Status> GetStatus(int page, int size)
        {
            throw new NotImplementedException();
        }

        public bool PutStatus(Status statusBacklog)
        {
            throw new NotImplementedException();
        }
    }
}
