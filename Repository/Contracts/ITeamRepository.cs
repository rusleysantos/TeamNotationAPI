using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface ITeamRepository
    {
        public Team AddTeam(Team team);
        public bool PutTeam(Team team);
        public Team GetTeam(int idTeam);
        public List<Team> GetTeam(int page, int size);
        public bool DeleteTeam(int idTeam);
    }
}
