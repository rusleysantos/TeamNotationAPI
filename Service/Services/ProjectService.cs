﻿using Repository.Contracts;
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

        public Task<int> AddProject(Project project, int idUser)
        {
            return _repository.AddProject(project, idUser);
        }

        public Task<bool> PutProject(Project project)
        {
            return _repository.PutProject(project);
        }

        public Task<List<Project>> GetProjects(int page, int size)
        {
            return _repository.GetProjects(page, size);
        }

        public Task<Project> GetProject(int idProject)
        {
            return _repository.GetProject(idProject);
        }

        public Task<bool> DeleteProject(int idProject)
        {
            return _repository.DeleteProject(idProject);
        }

        public Task<List<ProjectOption>> GetProjectOptions(int idUser)
        {
            return _repository.GetProjectOptions(idUser);
        }
    }
}
