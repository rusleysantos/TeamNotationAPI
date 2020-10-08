using System;
using System.Collections.Generic;
using System.Text;
using TeamNotationAPI.Models;

namespace Service.Contracts
{
    public interface INotationService
    {
        public Notation AddNotation(Notation notations);
        public bool PutNotation(Notation notations);
        public List<Notation> GetNotations(int page, int size);
        public Notation GetNotation(int idNotation);
        public bool DeleteNotation(int idNotation);
    }
}
