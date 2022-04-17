using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Services
{
    public class ProfileRepository : IProfileRepository
    {
        private AnnotationContext _con { get; set; }

        public ProfileRepository(AnnotationContext con)
        {
            _con = con;
        }

        public Profile AddProfile(Profile profile)
        {
            _con.Add(profile);
            _con.SaveChanges();

            return profile;
        }

        public bool DeleteProfile(int idProfile)
        {
            Profile returnProfile = _con.PROFILE.Where(x => x.idProfile == idProfile).First();

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
            return _con.PROFILE.Where(x => x.idProfile == idProfile).First();
        }

        public List<Profile> GetProfiles(int page, int size)
        {
            return _con.PROFILE
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutProfile(Profile profile)
        {
            Profile returnProfile = _con.PROFILE.Where(x => x.idProfile == profile.idProfile).First();

            if (returnProfile != null)
            {
                returnProfile.BirthDate = profile.BirthDate == null ? returnProfile.BirthDate : profile.BirthDate;
                //returnProfile.Gender = profile.Gender == null ? returnProfile.Gender : profile.Gender;
                returnProfile.Name = profile.Name == null ? returnProfile.Name : profile.Name;
                returnProfile.Surname = profile.Surname == null ? returnProfile.Surname : profile.Surname;

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

