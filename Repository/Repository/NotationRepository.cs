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

        public Notation AddNotation(Notation notation)
        {
            _con.Add(notation);
            _con.SaveChanges();

            return notation;
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

        public bool PutNotation(Notation notation)
        {
            Notation returnNotation = _con.Notation.Where(x => x.idNotation == notation.idNotation).First();

            if (returnNotation != null)
            {
                returnNotation.Attachments = notation.Attachments.Count == 0 ? returnNotation.Attachments : notation.Attachments;
                returnNotation.Description = notation.Description == null ? returnNotation.Description : notation.Description;
                returnNotation.Project = notation.Project == null ? returnNotation.Project : notation.Project;
                returnNotation.Title = notation.Title == null ? returnNotation.Title : notation.Title;
                returnNotation.User = notation.User == null ? returnNotation.User : notation.User;

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
