using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class ProjectRepository : IProjectRepository
    {
        private NotationContext _con { get; }

        public ProjectRepository(NotationContext con)
        {
            _con = con;
        }

        public async Task<int> AddProject(Project project, int idUser)
        {
            User user = _con.User.Where(x => x.idUser == idUser).First();

            _con.Add(project);
            await _con.SaveChangesAsync();

            ProjectUser projectUser = new ProjectUser
            {
                User = user,
                Project = project
            };

            _con.ProjectUser.Add(projectUser);
            await _con.SaveChangesAsync();

            return project.idProject;
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

        public async Task<Project> GetProject(int idProject)
        {
            return await _con.Project.Where(x => x.idProject == idProject).FirstAsync();
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
                //returnProject.Team = project.Team == null ? returnProject.Team : project.Team;
                //returnProject.Title = project.Title == null ? returnProject.Title : project.Title;
                //returnProject.User = project.User == null ? returnProject.User : project.User;

                _con.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<List<ProjectOption>> GetProjectOptions(int idUser)
        {
            List<int> ids = new List<int>();

            Task<List<ProjectUser>> projects = _con.ProjectUser
                                                .Include(j => j.User)
                                                .Where(x => x.User.idUser == idUser)
                                                .Select(x => new ProjectUser
                                                {
                                                    Project = x.Project,
                                                    User = x.User
                                                })
                                                .ToListAsync();

            foreach (var id in projects.Result)
            {
                ids.Add(id.Project.idProject);
            }

            return _con.Project
                        .Where(x => ids.Contains(x.idProject))
                        .Select(y => new ProjectOption
                        {
                            PercentDone = y.PercentDone,
                            idProjectOption = y.idProject,
                            Title = y.Title
                        })
                        .ToListAsync();

        }
    }
}
