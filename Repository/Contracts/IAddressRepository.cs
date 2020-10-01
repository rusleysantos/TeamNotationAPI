using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Contracts
{
    public interface IAddressRepository
    {
        public Address AddAddress(Address address);
        public bool PutAddress(Address address);
        public List<Address> GetAdresses(int page, int size);
        public Address GetAddress(int idAdress);
        public bool DeleteAddress(int idAdress);
    }
}
