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
            Task<User> user = _con.User.Where(x => x.idUser == idUser).FirstAsync();

            _con.Add(project);
            await _con.SaveChangesAsync();

            ProjectUser projectUser = new ProjectUser
            {
                User = user.Result,
                Project = project
            };

            _con.ProjectUser.Add(projectUser);
            await _con.SaveChangesAsync();

            return project.idProject;
        }

        public async Task<bool> DeleteProject(int idProject)
        {
            Task<Project> returnProject = _con.Project.Where(x => x.idProject == idProject).FirstAsync();

            if (returnProject != null)
            {
                _con.Remove(returnProject);
                await _con.SaveChangesAsync();
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

        public async Task<List<Project>> GetProjects(int page, int size)
        {
            return await _con.Project
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToListAsync();
        }

        public async Task<bool> PutProject(Project project)
        {
            Task<Project> returnProject = _con.Project.Where(x => x.idProject == project.idProject).FirstAsync();

            if (returnProject.Result != null)
            {
                returnProject.Result.PercentDone = project.PercentDone == 0.0 ? returnProject.Result.PercentDone : project.PercentDone;
                returnProject.Result.Title = project.Title == null ? returnProject.Result.Title : project.Title;

                await _con.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<ProjectOption>> GetProjectOptions(int idUser)
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

            return await _con.Project
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
