using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IProjectRepository
    {
        public Project AddProject(Project project);
        public bool PutProject(Project project);
        public Project GetProject(int idProject);
        public List<Project> GetProjects(int page, int size);
        public bool DeleteProject(int idProject);
    }
}
