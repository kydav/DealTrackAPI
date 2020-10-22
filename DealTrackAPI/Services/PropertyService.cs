using System;
using System.Collections.Generic;
using AutoMapper;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class PropertyService : IPropertyService
    {
        private IPropertyRepository _propertyRepository;
        private IMapper _mapper;

        public PropertyService(IPropertyRepository propertyRepository, IMapper mapper)
        {
            _propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        public void CreateProperty(PropertyDTO property)
        {
            throw new NotImplementedException();
        }

        public void DeleteProperty(int propertyId)
        {
            throw new NotImplementedException();
        }

        public PropertyDTO GetProperty(int propertyId)
        {
            throw new NotImplementedException();
        }

        public List<PropertyDTO> GetProperties()
        {
            throw new NotImplementedException();
        }

        public void UpdateProperty(PropertyDTO property)
        {
            throw new NotImplementedException();
        }
    }
}
