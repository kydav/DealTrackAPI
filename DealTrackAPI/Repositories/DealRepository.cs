using System;
using System.Collections.Generic;
using System.Linq;
using DealTrackAPI.Entities;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public class DealRepository : IDealRepository
    {
        private readonly DealTrackDBContext _context;
        public DealRepository(DealTrackDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateDeal(DealDTO deal)
        {
            throw new NotImplementedException();
        }

        public void DeleteDeal(int dealId)
        {
            throw new NotImplementedException();
        }

        public Deal GetDeal(int dealId)
        {
            return _context.Deals.Where(i => i.Id == dealId).FirstOrDefault();
        }

        public IEnumerable<DealDTO> GetDeals()
        {
            throw new NotImplementedException();
        }

        public void UpdateDeal(DealDTO deal)
        {
            throw new NotImplementedException();
        }
    }
}
