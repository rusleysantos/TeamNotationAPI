using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Services
{
    public class ImpedimentService: IImpedimentService
    {
        private IImpedimentService _repository { get; }
        public ImpedimentService(IImpedimentService repository)
        {
            _repository = repository;
        }

        public Impediment AddImpediment(Impediment impediment)
        {
            return _repository.AddImpediment(impediment);
        }

        public bool PutImpediment(Impediment impediment)
        {
            return _repository.PutImpediment(impediment);
        }

        public List<Impediment> GetImpediments(int page, int size)
        {
            return _repository.GetImpediments(page, size);
        }

        public Impediment GetImpediment(int idImpediment)
        {
            return _repository.GetImpediment(idImpediment);
        }

        public bool DeleteImpediment(int idImpediment)
        {
            return _repository.DeleteImpediment(idImpediment);
        }
    }
}
