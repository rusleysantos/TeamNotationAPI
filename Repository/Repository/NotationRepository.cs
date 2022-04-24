using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Repository.Services
{
    public class AnnotationRepository : IAnnotationRepository
    {
        private AnnotationContext _con { get; set; }

        public AnnotationRepository(AnnotationContext con)
        {
            _con = con;
        }

        public async Task<int> AddAnnotation(AnnotationDTO notation)
        {
            _con.Add(new Annotation
            {
                idProject = notation.idProject,
                idUser = notation.idUser,
                Description = notation.Description,
                PositionCard = notation.PositionCard,
                Title = notation.Title
            });

            await _con.SaveChangesAsync();

            return notation.idAnnotation;
        }

        public async Task<bool> DeleteAnnotation(int idAnnotation)
        {
            Task<Annotation> returnAnnotation = _con.ANNOTATION.Where(x => x.idAnnotation == idAnnotation).FirstAsync();

            if (returnAnnotation.Result != null)
            {
                returnAnnotation.Result.Deleted = true;

                _con.Update(returnAnnotation.Result);
                await _con.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Annotation> GetAnnotation(int idAnnotation)
        {
            return await _con.ANNOTATION.Where(x => x.idAnnotation == idAnnotation).FirstAsync();
        }

        public async Task<List<Annotation>> GetAnnotations(int page, int size, int idProject)
        {
            return await _con.ANNOTATION
                        .Skip((page - 1) * size)
                        .Take(size)
                        .Where(x => x.idProject == idProject && x.Deleted != true)
                        .ToListAsync();
        }

        public async Task<bool> PutAnnotation(AnnotationDTO notation)
        {
            Task<Annotation> returnAnnotation = _con.ANNOTATION.Where(x => x.idAnnotation == notation.idAnnotation).FirstAsync();

            if (returnAnnotation.Result != null)
            {
                //returnAnnotation.Result.Attachments = notation.Attachments.Count == 0 ? returnAnnotation.Result.Attachments : notation.Attachments;
                returnAnnotation.Result.Description = notation.Description == null ? returnAnnotation.Result.Description : notation.Description;
                //returnAnnotation.Result.Project = notation.Project == null ? returnAnnotation.Result.Project : notation.Project;
                returnAnnotation.Result.Title = notation.Title == null ? returnAnnotation.Result.Title : notation.Title;
                returnAnnotation.Result.PositionCard = notation.PositionCard == null ? returnAnnotation.Result.PositionCard : notation.PositionCard;

                _con.Update(returnAnnotation.Result);
                await _con.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
