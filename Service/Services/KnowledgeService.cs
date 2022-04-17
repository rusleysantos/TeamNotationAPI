using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class KnowledgeService : IKnowledgeService
    {
        private IKnowledgeService _repository { get; }
        public KnowledgeService(IKnowledgeService repository)
        {
            _repository = repository;
        }

        public Knowledge AddKnowledge(Knowledge knowledge)
        {
            return _repository.AddKnowledge(knowledge);
        }

        public bool PutKnowledge(Knowledge knowledge)
        {
            return _repository.PutKnowledge(knowledge);
        }

        public List<Knowledge> GetKnowledges(int page, int size)
        {
            return _repository.GetKnowledges(page, size);
        }

        public Knowledge GetKnowledge(int idKnowledge)
        {
            return _repository.GetKnowledge(idKnowledge);
        }

        public bool DeleteKnowledge(int idKnowledge)
        {
            return _repository.DeleteKnowledge(idKnowledge);
        }
    }
}
