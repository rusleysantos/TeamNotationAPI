using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Contracts
{
    public interface IProfileRepository
    {
        public Profile AddProfile(Profile profile);
        public bool PutProfile(Profile profile);
        public Profile GetProfile(int idProfile);
        public List<Profile> GetProfiles(int page, int size);
        public bool DeleteProfile(int idProfile);
    }
}
