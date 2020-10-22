using System;
using System.Collections.Generic;
using DealTrackAPI.Entities;

namespace DealTrackAPI.Repositories
{
    public interface ITitleCompanyRepository
    {
        public TitleCompany GetTitleCompany(int titleCompanyId);
        public List<TitleCompany> GetTitleCompanies();
        public void CreateTitleCompany(TitleCompany titleCompany);
        public void DeleteTitleCompany(TitleCompany titleCompany);
        public void UpdateTitleCompany(TitleCompany titleCompany);
    }
}
