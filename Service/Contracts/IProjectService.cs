using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface IProjectService
    {
        public Project AddProject(Project project);
        public bool PutProject(Project project);
        public List<Project> GetProjects(int page, int size);
        public Project GetProject(int idProject);
        public bool DeleteProject(int idProject);
    }
}
