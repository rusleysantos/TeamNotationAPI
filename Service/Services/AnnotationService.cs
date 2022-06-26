﻿using Repository.Contracts;
using Repository.DTO;
using Service.Contracts;
using System;
using System.Collections.Generic;
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
