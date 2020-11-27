using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface IProjectService
    {
        public Task<int> AddProject(Project project, int idUser);
        public Task<bool> PutProject(Project project);
        public Task<List<Project>> GetProjects(int page, int size);
        public Task<Project> GetProject(int idProject);
        public Task<bool> DeleteProject(int idProject);
        public Task<List<ProjectOption>> GetProjectOptions(int idUser);
    }
}
