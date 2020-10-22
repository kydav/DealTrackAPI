using System;
using System.Collections.Generic;
using DealTrackAPI.Entities;

namespace DealTrackAPI.Repositories
{
    public interface ILenderRepository
    {
        public Lender GetLender(int lenderId);
        public List<Lender> GetLenders();
        public void CreateLender(Lender lender);
        public void DeleteLender(Lender lender);
        public void UpdateLender(Lender lender);
    }
}
