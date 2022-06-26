using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Repository.Contracts
{
    public interface IAnnotationRepository
    {
        public Task<int> AddAnnotation(AnnotationDTO notation, ExecutionTask task = null);
        public Task<bool> PutAnnotation(AnnotationDTO notation, ExecutionTask task = null);
        public Task<Annotation> GetAnnotation(int idAnnotation);
        public Task<List<Annotation>> GetAnnotations(int page, int size, int idProject);
        public Task<bool> DeleteAnnotation(int idAnnotation);
    }
}
