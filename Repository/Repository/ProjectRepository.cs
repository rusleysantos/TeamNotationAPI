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

        public Project AddProject(Project project)
        {
            _con.Add(project);
            _con.SaveChanges();

            return project;
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

        public bool PutProject(Project project)
        {
            Project returnProject = _con.Project.Where(x => x.idProject == project.idProject).First();

            if (returnProject != null)
            {
                returnProject.PercentDone = project.PercentDone == 0.0 ? returnProject.PercentDone : project.PercentDone;
                returnProject.Team = project.Team == null ? returnProject.Team : project.Team;
                returnProject.Title = project.Title == null ? returnProject.Title : project.Title;
                returnProject.User = project.User == null ? returnProject.User : project.User;

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
