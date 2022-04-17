using Repository.Contracts;
using Repository.DTO;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class AnnotationService: IAnnotationService
    {
        private IAnnotationRepository _repository { get; }
        public AnnotationService(IAnnotationRepository repository)
        {
            _repository = repository;
        }

        public Task<int> AddAnnotation(AnnotationDTO notation)
        {
            return _repository.AddAnnotation(notation);
        }

        public Task<bool> PutAnnotation(AnnotationDTO notation)
        {
            return _repository.PutAnnotation(notation);
        }

        public Task<List<Annotation>> GetAnnotations(int page, int size, int idProject)
        {
            return _repository.GetAnnotations(page, size, idProject);
        }

        public Task<Annotation> GetAnnotation(int idNotation)
        {
            return _repository.GetAnnotation(idNotation);
        }

        public Task<bool> DeleteAnnotation(int idNotation)
        {
            return _repository.DeleteAnnotation(idNotation);
        }
    }
}
