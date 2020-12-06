using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class BacklogRepository : IBacklogRepository
    {
        private NotationContext _con { get; set; }
        public BacklogRepository(NotationContext con)
        {
            _con = con;
        }

        public Backlog AddBacklog(Backlog backlog)
        {
            _con.Add(backlog);
            _con.SaveChanges();

            return backlog;
        }

        public bool DeleteBacklog(int idBacklog)
        {
            Backlog returBacklog = _con.Backlog.Where(x => x.idBacklog == idBacklog).First();

            if (returBacklog != null)
            {
                _con.Remove(returBacklog);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Backlog GetBacklog(int idBacklog)
        {
            return _con.Backlog.Where(x => x.idBacklog == idBacklog).First();
        }

        public List<Backlog> GetBacklogs(int page, int size)
        {
            return _con.Backlog
                     .Skip((page - 1) * size)
                     .Take(size)
                     .ToList();
        }

        public bool PutBacklog(Backlog backlog)
        {
            Backlog returnBacklog = _con.Backlog.Where(x => x.idBacklog == backlog.idBacklog).First();

            if (returnBacklog != null)
            {
                returnBacklog.Category = String.IsNullOrEmpty(backlog.Category) ? returnBacklog.Category : backlog.Category;
                returnBacklog.Estimate = String.IsNullOrEmpty(backlog.Estimate) ? returnBacklog.Estimate : backlog.Estimate;
                returnBacklog.Importance = String.IsNullOrEmpty(backlog.Importance) ? returnBacklog.Importance : backlog.Importance;
                //returnBacklog.Mockup = String.IsNullOrEmpty(backlog.Mockup) ? returnBacklog.Mockup : backlog.Mockup;
                //returnBacklog.Precedence = backlog.Precedence == 0 ? returnBacklog.Precedence : backlog.Precedence;
                //returnBacklog.Project = backlog.Project == null ? returnBacklog.Project : backlog.Project;
                //returnBacklog.Status = backlog.Status == null ? returnBacklog.Status : backlog.Status;
                //returnBacklog.Story = backlog.Story == 0 ? returnBacklog.Story : backlog.Story;

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
