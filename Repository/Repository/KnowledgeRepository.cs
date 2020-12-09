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

        public Knowledge AddKnowledge(Knowledge knowledge)
        {
            _con.Add(knowledge);
            _con.SaveChanges();

            return knowledge;
        }

        public bool DeleteKnowledge(int idKnowledge)
        {
            Knowledge returKnowledge = _con.KNOWLEDGE.Where(x => x.idKnowledge == idKnowledge).First();

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
            return _con.KNOWLEDGE.Where(x => x.idKnowledge == idKnowledge).First();
        }

        public List<Knowledge> GetKnowledge(int page, int size)
        {
            return _con.KNOWLEDGE
                     .Skip((page - 1) * size)
                     .Take(size)
                     .ToList();
        }

        public bool PutKnowledge(Knowledge knowledge)
        {
            Knowledge returnKnowledge = _con.KNOWLEDGE.Where(x => x.idKnowledge == knowledge.idKnowledge).First();

            if (returnKnowledge != null)
            {
                returnKnowledge.Attachments = knowledge.Attachments.Count == 0 ? returnKnowledge.Attachments : knowledge.Attachments;
                returnKnowledge.Description = knowledge.Description == string.Empty ? returnKnowledge.Description : knowledge.Description;
                returnKnowledge.Tasks = knowledge.Tasks.Count == 0 ? returnKnowledge.Tasks : knowledge.Tasks;
                returnKnowledge.Title = knowledge.Title == null ? returnKnowledge.Title : knowledge.Title;

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
