using Repository.Contracts;
using Repository.DTO;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Service.Services
{
    public class AnnotationService : IAnnotationService
    {
        private IAnnotationRepository _repository { get; }
        private IExecutionTaskRepository _repositoryExecutionTask { get; }

        public AnnotationService(IAnnotationRepository repository, IExecutionTaskRepository repositoryExecutionTask)
        {
            _repository = repository;
            _repositoryExecutionTask = repositoryExecutionTask;
        }

        public Task<int> AddAnnotation(AnnotationDTO notation)
        {
            if (notation.idTask != 0)
            {
                ExecutionTask task = _repositoryExecutionTask.GetExecutionTask(notation.idTask).Result;
                return _repository.AddAnnotation(notation, task);
            }
            else
            {
                return _repository.AddAnnotation(notation);
            }

        }

        public Task<bool> PutAnnotation(AnnotationDTO notation)
        {
            if (notation.PositionCard != null)
            {
                notation.PositionCard = BuildPosition(notation.PositionCard.Split(") "));
            }

            if (notation.idTask != 0)
            {
                List<Annotation> annotations = new List<Annotation>();
                ExecutionTask task = _repositoryExecutionTask.GetExecutionTask(notation.idTask).Result;

                return _repository.PutAnnotation(notation, task);
            }
            else
            {
                return _repository.PutAnnotation(notation);
            }
        }

        private string BuildPosition(string[] styles)
        {
            List<string> preStryle = new List<string>();

            foreach (var style in styles)
            {

                if (style.Contains("translate3d"))
                {
                    if (!style.Contains(")"))
                    {
                        preStryle.Add(style + ")");
                    }
                    else
                    {
                        preStryle.Add(style);
                    }
                }
            }

            return string.Concat(preStryle.ToArray());
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
