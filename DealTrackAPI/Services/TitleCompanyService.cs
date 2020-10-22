using System;
using System.Collections.Generic;
using AutoMapper;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class TitleCompanyService : ITitleCompanyService
    {
        private ITitleCompanyRepository _titleCompanyRepository;
        private IMapper _mapper;

        public TitleCompanyService(ITitleCompanyRepository titleCompanyRepository, IMapper mapper)
        {
            _titleCompanyRepository = titleCompanyRepository;
            _mapper = mapper;
        }

        public void CreateTitleCompany(TitleCompanyDTO titleCompany)
        {
            throw new NotImplementedException();
        }

        public void DeleteTitleCompany(int titleCompanyId)
        {
            throw new NotImplementedException();
        }

        public TitleCompanyDTO GetTitleCompany(int titleCompanyId)
        {
            throw new NotImplementedException();
        }

        public List<TitleCompanyDTO> GetTitleCompanies()
        {
            throw new NotImplementedException();
        }

        public void UpdateTitleCompany(TitleCompanyDTO titleCompany)
        {
            throw new NotImplementedException();
        }
    }
}
