using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class KnowledgeRepository : IKnowledgeRepository
    {
        private NotationContext _con { get; set; }
        public KnowledgeRepository(NotationContext con)
        {
            _con = con;
        }

        public Knowledge AddKnowledge(Knowledge notation)
        {
            _con.Add(notation);
            _con.SaveChanges();

            return notation;
        }

        public bool DeleteKnowledge(int idKnowledge)
        {
            Knowledge returKnowledge = _con.Knowledge.Where(x => x.idKnowledge == idKnowledge).First();

            if (returKnowledge != null)
            {
                _con.Remove(returKnowledge);
                _con.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Knowledge GetKnowledge(int idKnowledge)
        {
            return _con.Knowledge.Where(x => x.idKnowledge == idKnowledge).First();
        }

        public List<Knowledge> GetKnowledge(int page, int size)
        {
            return _con.Knowledge
                     .Skip((page - 1) * size)
                     .Take(size)
                     .ToList();
        }

        public bool PutKnowledge(Knowledge notation)
        {
            Knowledge returnKnowledge = _con.Knowledge.Where(x => x.idKnowledge == notation.idKnowledge).First();

            if (returnKnowledge != null)
            {
                returnKnowledge.Attachments = notation.Attachments.Count == 0 ? returnKnowledge.Attachments : notation.Attachments;
                returnKnowledge.Description = notation.Description == string.Empty ? returnKnowledge.Description : notation.Description;
                returnKnowledge.Tasks = notation.Tasks.Count == 0 ? returnKnowledge.Tasks : notation.Tasks;
                returnKnowledge.Title = notation.Title == null ? returnKnowledge.Title : notation.Title;

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
