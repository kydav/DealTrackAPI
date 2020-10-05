using System;
using System.Collections.Generic;
using DealTrackAPI.Entities;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public interface IDealRepository
    {
        IEnumerable<DealDTO> GetDeals();
        Deal GetDeal(int dealId);
        void CreateDeal(Deal deal);
        void UpdateDeal(DealDTO deal);
        void DeleteDeal(int dealId);
    }
}
