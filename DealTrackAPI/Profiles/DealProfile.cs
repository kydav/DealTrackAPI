using System;
using AutoMapper;

namespace DealTrackAPI.Profiles
{
    public class DealProfile : Profile
    {
        public DealProfile()
        {
            CreateMap<Entities.Deal, Models.DealDTO>();
                //.Include<Entities.Appraiser, Models.AppraiserDTO>();
            CreateMap<Entities.Appraiser, Models.AppraiserDTO>();
            CreateMap<Entities.Comment, Models.CommentDTO>();
            CreateMap<Entities.User, Models.UserDTO>();
            CreateMap<Entities.Lender, Models.LenderDTO>();
            CreateMap<Entities.TitleCompany, Models.TitleCompanyDTO>();

            //CreateMap<Models.DealDTO, Entities.Deal>();
            //CreateMap<Models.AppraiserDTO, Entities.Appraiser>();
            //CreateMap<Models.CommentDTO, Entities.Comment>();
            //CreateMap<Models.UserDTO, Entities.User>();
            //CreateMap<Models.LenderDTO, Entities.Lender>();
            //CreateMap<Models.TitleCompanyDTO, Entities.TitleCompany>();
        }
    }
}
