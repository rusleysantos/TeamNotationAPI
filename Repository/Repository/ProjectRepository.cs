using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class ProjectRepository : IProjectRepository
    {
        private NotationContext _con { get; set; }

        public ProjectRepository(NotationContext con)
        {
            _con = con;
        }

        public Project AddProject(Project attach)
        {
            _con.Add(attach);
            _con.SaveChanges();

            return attach;
        }

        public bool DeleteProject(int idProject)
        {
            Project returnProject = _con.Project.Where(x => x.idProject == idProject).First();

            if (returnProject != null)
            {
                _con.Remove(returnProject);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Project GetProject(int idProject)
        {
            return _con.Project.Where(x => x.idProject == idProject).First();
        }

        public List<Project> GetProjects(int page, int size)
        {
            return _con.Project
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutProject(Project attach)
        {
            Project returnProject = _con.Project.Where(x => x.idProject == attach.idProject).First();

            if (returnProject != null)
            {
                returnProject.PercentDone = attach.PercentDone == 0.0 ? returnProject.PercentDone : attach.PercentDone;
                returnProject.Team = attach.Team == null ? returnProject.Team : attach.Team;
                returnProject.Title = attach.Title == null ? returnProject.Title : attach.Title;
                returnProject.User = attach.User == null ? returnProject.User : attach.User;

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
