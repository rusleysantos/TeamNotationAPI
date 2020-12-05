using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
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

        public async Task<Notation> AddNotation(Notation notation)
        {
            _con.Add(notation);
            _con.SaveChanges();

            return notation;
        }

        public async Task<bool> DeleteNotation(int idNotation)
        {
            Task<Notation> returnNotation = _con.Notation.Where(x => x.idNotation == idNotation).FirstAsync();

            if (returnNotation.Result != null)
            {
                _con.Remove(returnNotation);
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
            return await _con.Notation.Where(x => x.idNotation == idNotation).FirstAsync();
        }

        public async Task<List<Notation>> GetNotations(int page, int size)
        {
            return await _con.Notation
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToListAsync();
        }

        public async Task<bool> PutNotation(Notation notation)
        {
            Task<Notation> returnNotation = _con.Notation.Where(x => x.idNotation == notation.idNotation).FirstAsync();

            if (returnNotation.Result != null)
            {
                returnNotation.Result.Attachments = notation.Attachments.Count == 0 ? returnNotation.Result.Attachments : notation.Attachments;
                returnNotation.Result.Description = notation.Description == null ? returnNotation.Result.Description : notation.Description;
                returnNotation.Result.Project = notation.Project == null ? returnNotation.Result.Project : notation.Project;
                returnNotation.Result.Title = notation.Title == null ? returnNotation.Result.Title : notation.Title;
                returnNotation.Result.User = notation.User == null ? returnNotation.Result.User : notation.User;
                returnNotation.Result.PositionCard = notation.PositionCard == null ? returnNotation.Result.PositionCard : notation.PositionCard;

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
