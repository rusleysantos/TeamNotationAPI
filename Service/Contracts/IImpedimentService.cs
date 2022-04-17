using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Contracts
{
    public interface IImpedimentService
    {
        public Impediment AddImpediment(Impediment impediment);
        public bool PutImpediment(Impediment impediment);
        public List<Impediment> GetImpediments(int page, int size);
        public Impediment GetImpediment(int idImpediment);
        public bool DeleteImpediment(int idImpediment);
    }
}
