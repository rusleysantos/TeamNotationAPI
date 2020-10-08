using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class ProjectService: IProjectService
    {
        private IProjectService _repository { get; }
        public ProjectService(IProjectService repository)
        {
            _repository = repository;
        }

        public Project AddProject(Project project)
        {
            return _repository.AddProject(project);
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
    }
}
