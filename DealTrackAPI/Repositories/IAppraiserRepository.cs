using System;
using System.Collections.Generic;
using DealTrackAPI.Entities;

namespace DealTrackAPI.Repositories
{
    public interface IAppraiserRepository
    {
        public Appraiser GetAppraiser(int appraiserId);
        public List<Appraiser> GetAppraisers();
        public void CreateAppraiser(Appraiser appraiser);
        public void DeleteAppraiser(Appraiser appraiser);
        public void UpdateAppraiser(Appraiser appraiser);
    }
}
