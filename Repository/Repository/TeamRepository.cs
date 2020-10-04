using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class TeamRepository : ITeamRepository
    {
        private NotationContext _con { get; set; }

        public TeamRepository(NotationContext con)
        {
            _con = con;
        }

        public Team AddTeam(Team attach)
        {
            _con.Add(attach);
            _con.SaveChanges();

            return attach;
        }

        public bool DeleteTeam(int idTeam)
        {
            Team returnTeam = _con.Team.Where(x => x.idTeam == idTeam).First();

            if (returnTeam != null)
            {
                _con.Remove(returnTeam);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Team GetTeam(int idTeam)
        {
            return _con.Team.Where(x => x.idTeam == idTeam).First();
        }

        public List<Team> GetTeams(int page, int size)
        {
            return _con.Team
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutTeam(Team attach)
        {
            Team returnTeam = _con.Team.Where(x => x.idTeam == attach.idTeam).First();

            if (returnTeam != null)
            {
                returnTeam.Description = attach.Description == null ? returnTeam.Description : attach.Description;
                returnTeam.Name = attach.Name == null ? returnTeam.Name : attach.Name;

                _con.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

