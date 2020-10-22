using System;
using System.Collections.Generic;
using AutoMapper;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class LenderService : ILenderService
    {
        private ILenderRepository _lenderRepository;
        private IMapper _mapper;

        public LenderService(ILenderRepository lenderRepository, IMapper mapper)
        {
            _lenderRepository = lenderRepository;
            _mapper = mapper;
        }

        public void CreateLender(LenderDTO lender)
        {
            throw new NotImplementedException();
        }

        public void DeleteLender(int lenderId)
        {
            throw new NotImplementedException();
        }

        public LenderDTO GetLender(int lenderId)
        {
            throw new NotImplementedException();
        }

        public List<LenderDTO> GetLenders()
        {
            throw new NotImplementedException();
        }

        public void UpdateLender(LenderDTO lender)
        {
            throw new NotImplementedException();
        }
    }
}
