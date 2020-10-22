using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface ITitleCompanyService
    {
        public TitleCompanyDTO GetTitleCompany(int titleCompanyId);
        public List<TitleCompanyDTO> GetTitleCompanies();
        public void CreateTitleCompany(TitleCompanyDTO titleCompany);
        public void DeleteTitleCompany(int titleCompanyId);
        public void UpdateTitleCompany(TitleCompanyDTO titleCompany);
    }
}
