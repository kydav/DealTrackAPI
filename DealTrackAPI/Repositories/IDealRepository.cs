using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public interface IDealRepository
    {
        IEnumerable<DealDTO> GetDeals();
        DealDTO GetDeal(int dealId);
        void CreateDeal(DealDTO deal);
        void UpdateDeal(DealDTO deal);
        void DeleteDeal(int dealId);
    }
}
