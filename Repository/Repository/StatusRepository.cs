using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAnnotationAPI.Models;

namespace Repository.Services
{
    public class StatusRepository : IStatusRepository
    {
        private AnnotationContext _con { get; set; }

        public StatusRepository(AnnotationContext con)
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
            Status returnStatus = _con.STATUS.Where(x => x.idStatus == idStatus).First();

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
            return await _con.STATUS.Where(x => x.idStatus == idStatus).FirstAsync();
        }

        public async Task<List<Status>> GetStatus(int page, int size)
        {
            return await _con.STATUS
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToListAsync();
        }

        public async Task<List<Status>> GetStatusAllByType(int page, int size, string type)
        {
            return await _con.STATUS
                        .Skip((page - 1) * size)
                        .Take(size)
                        .Where(x => x.Type == type)
                        .ToListAsync();
        }

        public async Task<bool> PutStatus(Status status)
        {
            Task<Status> returnStatus = _con.STATUS.Where(x => x.idStatus == status.idStatus).FirstAsync();

            if (returnStatus.Result != null)
            {
                returnStatus.Result.Description = status.Description == string.Empty ? returnStatus.Result.Description : status.Description;
                returnStatus.Result.Type = status.Type == string.Empty ? returnStatus.Result.Type : status.Type;

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
