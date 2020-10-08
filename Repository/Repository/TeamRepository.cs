﻿using Repository.Contracts;
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

        public Team AddTeam(Team team)
        {
            _con.Add(team);
            _con.SaveChanges();

            return team;
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

        public bool PutTeam(Team team)
        {
            Team returnTeam = _con.Team.Where(x => x.idTeam == team.idTeam).First();

            if (returnTeam != null)
            {
                returnTeam.Description = team.Description == null ? returnTeam.Description : team.Description;
                returnTeam.Name = team.Name == null ? returnTeam.Name : team.Name;

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

