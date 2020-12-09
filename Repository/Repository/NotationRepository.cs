using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNotationAPI.Models;

namespace Repository.Services
{
    public class NotationRepository : INotationRepository
    {
        private NotationContext _con { get; set; }

        public NotationRepository(NotationContext con)
        {
            _con = con;
        }

        public async Task<int> AddNotation(NotationDTO notation)
        {
            _con.Add(new Notation
            {
                idProject = notation.idProject,
                idUser = notation.idUser,
                Description = notation.Description,
                PositionCard = notation.PositionCard,
                Title = notation.Title
            });

            await _con.SaveChangesAsync();

            return notation.idNotation;
        }

        public async Task<bool> DeleteNotation(int idNotation)
        {
            Task<Notation> returnNotation = _con.NOTATION.Where(x => x.idNotation == idNotation).FirstAsync();

            if (returnNotation.Result != null)
            {
                returnNotation.Result.Deleted = true;

                _con.Update(returnNotation.Result);
                await _con.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Notation> GetNotation(int idNotation)
        {
            return await _con.NOTATION.Where(x => x.idNotation == idNotation).FirstAsync();
        }

        public async Task<List<Notation>> GetNotations(int page, int size, int idProject)
        {
            return await _con.NOTATION
                        .Skip((page - 1) * size)
                        .Take(size)
                        .Where(x => x.idProject == idProject && x.Deleted != true)
                        .ToListAsync();
        }

        public async Task<bool> PutNotation(NotationDTO notation)
        {
            Task<Notation> returnNotation = _con.NOTATION.Where(x => x.idNotation == notation.idNotation).FirstAsync();

            if (returnNotation.Result != null)
            {
                //returnNotation.Result.Attachments = notation.Attachments.Count == 0 ? returnNotation.Result.Attachments : notation.Attachments;
                returnNotation.Result.Description = notation.Description == null ? returnNotation.Result.Description : notation.Description;
                //returnNotation.Result.Project = notation.Project == null ? returnNotation.Result.Project : notation.Project;
                returnNotation.Result.Title = notation.Title == null ? returnNotation.Result.Title : notation.Title;
                returnNotation.Result.PositionCard = notation.PositionCard == null ? returnNotation.Result.PositionCard : notation.PositionCard;

                _con.Update(returnNotation.Result);
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
