using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface ITeamService
    {
        public Team AddTeam(Team backlog);
        public bool PutTeam(Team backlog);
        public List<Team> GetTeams(int page, int size);
        public Team GetTeam(int idTeam);
        public bool DeleteTeam(int idTeam);
    }
}
