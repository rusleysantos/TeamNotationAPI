using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class AddressService : IAddressService
    {
        private IAddressRepository _repository { get; set; }
        public AddressService(IAddressRepository repository)
        {
            _repository = repository;
        }

        public Address AddAddress(Address address)
        {
            return _repository.AddAddress(address);
        }

        public bool DeleteAddress(int idAdress)
        {
            return _repository.DeleteAddress(idAdress);
        }

        public Address GetAddress(int idAdress)
        {
            return _repository.GetAddress(idAdress);
        }

        public List<Address> GetAdresses(int page, int size)
        {
            return _repository.GetAdresses(page, size);
        }

        public bool PutAddress(Address address)
        {
            return _repository.PutAddress(address);
        }
    }
}
