using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface IDealService
    {
        Task<IEnumerable<DealDTO>> GetActiveDeals();
        DealDTO GetDeal(int dealId);
        void CreateDeal(DealDTO deal);
        void DeleteDeal(int dealId);
        void UpdateDeal(DealDTO deal);
        Task<IEnumerable<DealDTO>> GetAllDeals();
    }
}
