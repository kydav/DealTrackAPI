using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class DealService : IDealService
    {
        private DealRepository _dealRepository;

        public DealService(DealRepository dealRepository)
        {
            _dealRepository = dealRepository;
        }

        public void CreateDeal(DealDTO deal)
        {
            _dealRepository.CreateDeal(deal);
        }

        public void DeleteDeal(int dealId)
        {
            _dealRepository.DeleteDeal(dealId);
        }

        public async Task<DealDTO> GetDeal(int dealId)
        {
            return _dealRepository.GetDeal(dealId);
        }

        public Task<IEnumerable<DealDTO>> GetActiveDeals()
        {
            throw new NotImplementedException();
        }

        public void UpdateDeal(DealDTO deal)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DealDTO>> GetAllDeals()
        {
            throw new NotImplementedException();
        }
    }
}
