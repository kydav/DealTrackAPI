using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class DealService : IDealService
    {
        private IDealRepository _dealRepository;
        private readonly IMapper _mapper;

        public DealService(IDealRepository dealRepository, IMapper mapper)
        {
            _dealRepository = dealRepository;
            _mapper = mapper;
        }

        public void CreateDeal(DealDTO deal)
        {
            _dealRepository.CreateDeal(deal);
        }

        public void DeleteDeal(int dealId)
        {
            _dealRepository.DeleteDeal(dealId);
        }

        public DealDTO GetDeal(int dealId)
        {
            var deal = _dealRepository.GetDeal(dealId);
            return  _mapper.Map<DealDTO>(deal);
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
