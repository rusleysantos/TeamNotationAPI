using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Repository.Contracts
{
    public interface IKnowledgeRepository
    {
        public Knowledge AddKnowledge(Knowledge knowledge);
        public bool PutKnowledge(Knowledge knowledge);
        public Knowledge GetKnowledge(int idKnowledge);
        public List<Knowledge> GetKnowledge(int page, int size);
        public bool DeleteKnowledge(int idKnowledge);
    }
}
