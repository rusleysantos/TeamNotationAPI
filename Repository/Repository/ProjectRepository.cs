using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Repository.Services
{
    public class ProjectRepository : IProjectRepository
    {
        private AnnotationContext _con { get; }

        public ProjectRepository(AnnotationContext con)
        {
            _con = con;
        }

        public async Task<int> AddProject(Project project, int idUser)
        {

            _con.Add(project);
            await _con.SaveChangesAsync();

            PROJECT_USER PROJECT_USER = new PROJECT_USER
            {
                idUser = idUser,
                Project = project
            };

            _con.PROJECT_USER.Add(PROJECT_USER);
            await _con.SaveChangesAsync();

            return project.idProject;
        }

        public async Task<bool> DeleteProject(int idProject)
        {
            Task<Project> returnProject = _con.PROJECT.Where(x => x.idProject == idProject).FirstAsync();

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
            return await _con.PROJECT.Where(x => x.idProject == idProject).FirstAsync();
        }

        public async Task<List<Project>> GetProjects(int page, int size)
        {
            return await _con.PROJECT
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToListAsync();
        }

        public async Task<bool> PutProject(Project project)
        {
            Task<Project> returnProject = _con.PROJECT.Where(x => x.idProject == project.idProject).FirstAsync();

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

            Task<List<PROJECT_USER>> projects = _con.PROJECT_USER
                                                    .Include(j => j.Project) 
                                                    .Where(x => x.idUser == idUser)
                                                    .ToListAsync();

            if (projects.Result != null)
            {
                foreach (var id in projects.Result)
                {
                    ids.Add(id.Project.idProject);
                }
            }

            return await _con.PROJECT
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
