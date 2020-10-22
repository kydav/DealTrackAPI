using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface IPropertyService
    {
        public PropertyDTO GetProperty(int propertyId);
        public List<PropertyDTO> GetProperties();
        public void CreateProperty(PropertyDTO property);
        public void DeleteProperty(int propertyId);
        public void UpdateProperty(PropertyDTO property);
    }
}
