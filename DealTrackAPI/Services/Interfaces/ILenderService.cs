using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface ILenderService
    {
        public LenderDTO GetLender(int lenderId);
        public List<LenderDTO> GetLenders();
        public void CreateLender(LenderDTO lender);
        public void DeleteLender(int lenderId);
        public void UpdateLender(LenderDTO lender);
    }
}
