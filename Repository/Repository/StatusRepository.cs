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
    public class StatusRepository : IStatusRepository
    {
        private NotationContext _con { get; set; }

        public StatusRepository(NotationContext con)
        {
            _con = con;
        }

        public async Task<Status> AddStatus(Status status)
        {
            _con.Add(status);
            await _con.SaveChangesAsync();

            return status;
        }

        public async Task<bool> DeleteStatus(int idStatus)
        {
            Status returnStatus = _con.Status.Where(x => x.idStatus == idStatus).First();

            if (returnStatus != null)
            {
                _con.Remove(returnStatus);
                await _con.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Status> GetStatus(int idStatus)
        {
            return await _con.Status.Where(x => x.idStatus == idStatus).FirstAsync();
        }

        public async Task<List<Status>> GetStatus(int page, int size)
        {
            return await _con.Status
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToListAsync();
        }

        public async Task<List<Status>> GetStatusAllByType(int page, int size, string type)
        {
            return await _con.Status
                        .Skip((page - 1) * size)
                        .Take(size)
                        .Where(x => x.Tipo == type)
                        .ToListAsync();
        }

        public async Task<bool> PutStatus(Status status)
        {
            Task<Status> returnStatus = _con.Status.Where(x => x.idStatus == status.idStatus).FirstAsync();

            if (returnStatus.Result != null)
            {
                returnStatus.Result.Description = status.Description == string.Empty ? returnStatus.Result.Description : status.Description;
                returnStatus.Result.Tipo = status.Tipo == string.Empty ? returnStatus.Result.Tipo : status.Tipo;

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
