using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class TeamService: ITeamService
    {
        private ITeamService _repository { get; }
        public TeamService(ITeamService repository)
        {
            _repository = repository;
        }

        public Team AddTeam(Team team)
        {
            return _repository.AddTeam(team);
        }

        public bool PutTeam(Team impediment)
        {
            return _repository.PutTeam(impediment);
        }

        public List<Team> GetTeams(int page, int size)
        {
            return _repository.GetTeams(page, size);
        }

        public Team GetTeam(int idTeam)
        {
            return _repository.GetTeam(idTeam);
        }

        public bool DeleteTeam(int idTeam)
        {
            return _repository.DeleteTeam(idTeam);
        }
    }
}
