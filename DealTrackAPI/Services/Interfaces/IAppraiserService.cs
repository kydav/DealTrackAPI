using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface IAppraiserService
    {
        public AppraiserDTO GetAppraiser(int appraiserId);
        public List<AppraiserDTO> GetAppraisers();
        public void CreateAppraiser(AppraiserDTO appraiser);
        public void DeleteAppraiser(int appraiserId);
        public void UpdateAppraiser(AppraiserDTO appraiser);
    }
}
