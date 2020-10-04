using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class ImpedimentRepository: IImpedimentRepository
    {
        private NotationContext _con { get; set; }
        public ImpedimentRepository(NotationContext con)
        {
            _con = con;
        }

        public Impediment AddImpediment(Impediment impediment)
        {
            _con.Add(impediment);
            _con.SaveChanges();

            return impediment;
        }

        public bool DeleteImpediment(int idImpediment)
        {
            Impediment returImpediment = _con.Impediment.Where(x => x.idImpediment == idImpediment).First();

            if (returImpediment != null)
            {
                _con.Remove(returImpediment);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Impediment GetImpediment(int idImpediment)
        {
            return _con.Impediment.Where(x => x.idImpediment == idImpediment).First();
        }

        public List<Impediment> GetImpediments(int page, int size)
        {
            return _con.Impediment
                         .Skip((page - 1) * size)
                         .Take(size)
                         .ToList();
        }

        public bool PutImpediment(Impediment impediment)
        {
            Impediment returnImpediment = _con.Impediment.Where(x => x.idImpediment == impediment.idImpediment).First();

            if (returnImpediment != null)
            {
                returnImpediment.Attachments = impediment.Attachments.Count == 0  ? returnImpediment.Attachments : impediment.Attachments;
                returnImpediment.Description = impediment.Description == string.Empty ? returnImpediment.Description : impediment.Description;
                returnImpediment.Tasks = impediment.Tasks.Count == 0 ? returnImpediment.Tasks : impediment.Tasks;
                returnImpediment.Title = impediment.Title == string.Empty ? returnImpediment.Title : impediment.Title;
                returnImpediment.User = impediment.User == null ? returnImpediment.User : impediment.User;
           
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
