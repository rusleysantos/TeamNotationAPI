using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Contracts
{
    public interface IAnnotationService
    {
        public Task<int> AddAnnotation(AnnotationDTO notations);
        public Task<bool> PutAnnotation(AnnotationDTO notations);
        public Task<List<Annotation>> GetAnnotations(int page, int size, int idProject);
        public Task<Annotation> GetAnnotation(int idNotation);
        public Task<bool> DeleteAnnotation(int idNotation);
    }
}
