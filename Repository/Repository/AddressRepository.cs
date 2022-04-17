using Microsoft.EntityFrameworkCore.Internal;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TeamAnnotationAPI.Models;

namespace Repository.Services
{
    public class AddressRepository : IAddressRepository
    {
        private AnnotationContext _con { get; set; }

        public AddressRepository(AnnotationContext con)
        {
            _con = con;
        }

        public Address AddAddress(Address address)
        {
            _con.Add(address);
            _con.SaveChanges();

            return address;
        }

        public bool DeleteAddress(int idAdress)
        {
            Address returnAddress = _con.ADDRESS.Where(x => x.idAddress == idAdress).First();

            if (returnAddress != null)
            {
                _con.Remove(returnAddress);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public Address GetAddress(int idAdress)
        {
            return _con.ADDRESS.Where(x => x.idAddress == idAdress).First();
        }

        public List<Address> GetAdresses(int page, int size)
        {
            return _con.ADDRESS
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutAddress(Address address)
        {
            Address returnAddress = _con.ADDRESS.Where(x => x.idAddress == address.idAddress).First();

            if (returnAddress != null)
            {
                returnAddress.Countrie = address.Countrie == null ? returnAddress.Countrie : address.Countrie;
                returnAddress.Number = address.Number == 0 ? returnAddress.Number : address.Number;
                returnAddress.Street = address.Street == null ? returnAddress.Street : address.Street;
                returnAddress.Latitude = address.Latitude == null ? returnAddress.Latitude : address.Latitude;
                returnAddress.Longitude = address.Longitude == null ? returnAddress.Longitude : address.Longitude;

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
