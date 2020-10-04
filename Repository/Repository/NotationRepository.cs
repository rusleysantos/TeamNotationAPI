using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class NotationRepository : INotationRepository
    {
        private NotationContext _con { get; set; }

        public NotationRepository(NotationContext con)
        {
            _con = con;
        }

        public Notation AddNotation(Notation attach)
        {
            _con.Add(attach);
            _con.SaveChanges();

            return attach;
        }

        public bool DeleteNotation(int idNotation)
        {
            Notation returnNotation = _con.Notation.Where(x => x.idNotation == idNotation).First();

            if (returnNotation != null)
            {
                _con.Remove(returnNotation);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Notation GetNotation(int idNotation)
        {
            return _con.Notation.Where(x => x.idNotation == idNotation).First();
        }

        public List<Notation> GetNotations(int page, int size)
        {
            return _con.Notation
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }

        public bool PutNotation(Notation attach)
        {
            Notation returnNotation = _con.Notation.Where(x => x.idNotation == attach.idNotation).First();

            if (returnNotation != null)
            {
                returnNotation.Attachments = attach.Attachments.Count == 0 ? returnNotation.Attachments : attach.Attachments;
                returnNotation.Description = attach.Description == null ? returnNotation.Description : attach.Description;
                returnNotation.Project = attach.Project == null ? returnNotation.Project : attach.Project;
                returnNotation.Title = attach.Title == null ? returnNotation.Title : attach.Title;
                returnNotation.User = attach.User == null ? returnNotation.User : attach.User;

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
