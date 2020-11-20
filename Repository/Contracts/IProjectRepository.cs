using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IProjectRepository
    {
        public void AddProject(Project project, int idUser);
        public bool PutProject(Project project);
        public Project GetProject(int idProject);
        public List<Project> GetProjects(int page, int size);
        public bool DeleteProject(int idProject);
        public Task<List<ProjectOption>> GetProjectOptions(int idUser);
    }
}
