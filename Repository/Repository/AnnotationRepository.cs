using Microsoft.Data.SqlClient;
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

        public async Task<int> AddAnnotation(AnnotationDTO notation, ExecutionTask task = null)
        {
            if (task != null)
            {
                _con.Add(new Annotation
                {
                    idProject = notation.idProject,
                    idUser = notation.idUser,
                    Description = notation.Description,
                    PositionCard = notation.PositionCard,
                    Title = notation.Title,
                    ColorBackground = task.ColorBackground,
                    ColorText = task.ColorText,
                });
            }
            else
            {
                _con.Add(new Annotation
                {
                    idProject = notation.idProject,
                    idUser = notation.idUser,
                    Description = notation.Description,
                    PositionCard = notation.PositionCard,
                    Title = notation.Title,
                    ColorBackground = notation.ColorBackground,
                    ColorText = notation.ColorText
                });
            }

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

            return await _con.ANNOTATION
                        .Where(x => x.idAnnotation == idAnnotation)
                        .FirstAsync();
        }

        public async Task<List<Annotation>> GetAnnotations(int page, int size, int idProject)
        {
            return await _con.ANNOTATION
                        .Skip((page - 1) * size)
                        .Take(size)
                        .Where(x => x.idProject == idProject && x.Deleted != true)
                        .ToListAsync();
        }

        public async Task<bool> PutAnnotation(AnnotationDTO notation, ExecutionTask task = null)
        {
            var returnAnnotation = await _con.ANNOTATION.Where(x => x.idAnnotation == notation.idAnnotation).FirstAsync();

            if (returnAnnotation != null)
            {
                //returnAnnotation.Result.Attachments = notation.Attachments.Count == 0 ? returnAnnotation.Result.Attachments : notation.Attachments;
                returnAnnotation.Description = notation.Description == null ? returnAnnotation.Description : notation.Description;
                //returnAnnotation.Result.Project = notation.Project == null ? returnAnnotation.Result.Project : notation.Project;
                returnAnnotation.Title = notation.Title == null ? returnAnnotation.Title : notation.Title;
                returnAnnotation.PositionCard = notation.PositionCard == null ? returnAnnotation.PositionCard : notation.PositionCard;

                if (task != null)
                {
                    returnAnnotation.ColorBackground = task.ColorBackground == null ? "" : task.ColorBackground;
                    returnAnnotation.ColorText = task.ColorText == null ? "" : task.ColorText;

                    var teste = await _con.Database.ExecuteSqlRawAsync($@"UPDATE ANNOTATION
                                                                        SET ExecutionTaskidTask = {task.idTask}
                                                                        WHERE ID_ANNOTATION = {notation.idAnnotation};");
                    await _con.SaveChangesAsync();

                    return true;

                }
                else
                {
                    returnAnnotation.ColorBackground = notation.ColorBackground == null ? returnAnnotation.ColorBackground : notation.ColorBackground;
                    returnAnnotation.ColorText = notation.ColorText == null ? returnAnnotation.ColorText : notation.ColorText;
                    _con.Update(returnAnnotation);
                    await _con.SaveChangesAsync();

                    return true;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
