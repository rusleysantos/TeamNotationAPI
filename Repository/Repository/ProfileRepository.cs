using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class ProfileRepository : IProfileRepository
    {
        private NotationContext _con { get; set; }

        public ProfileRepository(NotationContext con)
        {
            _con = con;
        }

        public Profile AddProfile(Profile attach)
        {
            _con.Add(attach);
            _con.SaveChanges();

            return attach;
        }

        public bool DeleteProfile(int idProfile)
        {
            Profile returnProfile = _con.Profile.Where(x => x.idProfile == idProfile).First();

            if (returnProfile != null)
            {
                _con.Remove(returnProfile);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Profile GetProfile(int idProfile)
        {
            return _con.Profile.Where(x => x.idProfile == idProfile).First();
        }

        public List<Profile> GetProfiles(int page, int size)
        {
            return _con.Profile
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutProfile(Profile attach)
        {
            Profile returnProfile = _con.Profile.Where(x => x.idProfile == attach.idProfile).First();

            if (returnProfile != null)
            {
                returnProfile.BirthDate = attach.BirthDate == null ? returnProfile.BirthDate : attach.BirthDate;
                returnProfile.Gender = attach.Gender == null ? returnProfile.Gender : attach.Gender;
                returnProfile.Name = attach.Name == null ? returnProfile.Name : attach.Name;
                returnProfile.Surname = attach.Surname == null ? returnProfile.Surname : attach.Surname;

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

