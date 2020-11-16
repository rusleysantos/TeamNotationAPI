using Repository.Contracts;
using Repository.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class ProjectService : IProjectService
    {
        private IProjectRepository _repository { get; }
        public ProjectService(IProjectRepository repository)
        {
            _repository = repository;
        }

        public void AddProject(Project project)
        {
            _repository.AddProject(project);
        }

        public bool PutProject(Project project)
        {
            return _repository.PutProject(project);
        }

        public List<Project> GetProjects(int page, int size)
        {
            return _repository.GetProjects(page, size);
        }

        public Project GetProject(int idProject)
        {
            return _repository.GetProject(idProject);
        }

        public bool DeleteProject(int idProject)
        {
            return _repository.DeleteProject(idProject);
        }

        public Task<List<ProjectOption>> GetProjectOptions(int idUser)
        {
            return _repository.GetProjectOptions(idUser);
        }
    }
}
