using System;
using AutoMapper;

namespace DealTrackAPI.Profiles
{
    public class DealProfile : Profile
    {
        public DealProfile()
        {
            CreateMap<Entities.Deal, Models.DealDTO>();
            CreateMap<Entities.Appraiser, Models.AppraiserDTO>();
            CreateMap<Entities.Comment, Models.CommentDTO>();
            CreateMap<Models.DealDTO, Entities.Deal>();

        }
    }
}
