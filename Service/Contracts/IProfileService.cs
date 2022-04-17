using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Contracts
{
    public interface IProfileService
    {
        public Profile AddProfile(Profile profile);
        public bool PutProfile(Profile profile);
        public List<Profile> GetProfiles(int page, int size);
        public Profile GetProfile(int idProfile);
        public bool DeleteProfile(int idProfile);
    }
}
