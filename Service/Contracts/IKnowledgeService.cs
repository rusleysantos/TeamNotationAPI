using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface IKnowledgeService
    {
        public Knowledge AddKnowledge(Knowledge knowledge);
        public bool PutKnowledge(Knowledge knowledge);
        public List<Knowledge> GetKnowledges(int page, int size);
        public Knowledge GetKnowledge(int idKnowledge);
        public bool DeleteKnowledge(int idKnowledge);
    }
}
