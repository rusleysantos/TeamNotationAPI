using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Contracts
{
    public interface IImpedimentRepository
    {
        public Impediment AddImpediment(Impediment impediment);
        public bool PutImpediment(Impediment impediment);
        public Impediment GetImpediment(int idImpediment);
        public List<Impediment> GetImpediments(int page, int size);
        public bool DeleteImpediment(int idImpediment);
    }
}
