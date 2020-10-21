using System;
using System.Collections.Generic;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class AppraiserService : IAppraiserService
    {
        public IAppraiserRepository _appraiserRepository;

        public AppraiserService(IAppraiserRepository appraiserRepository)
        {
            _appraiserRepository = appraiserRepository;
        }

        public void CreateAppraiser(AppraiserDTO appraiser)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppraiser(int appraiserId)
        {
            throw new NotImplementedException();
        }

        public AppraiserDTO GetAppraiser(int appraiserId)
        {
            throw new NotImplementedException();
        }

        public List<AppraiserDTO> GetAppraisers()
        {
            throw new NotImplementedException();
        }

        public void UpdateAppraiser(AppraiserDTO appraiser)
        {
            throw new NotImplementedException();
        }
    }
}
