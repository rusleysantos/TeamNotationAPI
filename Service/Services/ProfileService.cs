using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class ProfileService : IProfileService
    {
        private IProfileService _repository { get; }
        public ProfileService(IProfileService repository)
        {
            _repository = repository;
        }

        public Profile AddProfile(Profile profile)
        {
            return _repository.AddProfile(profile);
        }

        public bool PutProfile(Profile profile)
        {
            return _repository.PutProfile(profile);
        }

        public List<Profile> GetProfiles(int page, int size)
        {
            return _repository.GetProfiles(page, size);
        }

        public Profile GetProfile(int idProfile)
        {
            return _repository.GetProfile(idProfile);
        }

        public bool DeleteProfile(int idProfile)
        {
            return _repository.DeleteProfile(idProfile);
        }
    }
}
