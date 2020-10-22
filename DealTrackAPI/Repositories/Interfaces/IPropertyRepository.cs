using System;
using System.Collections.Generic;
using DealTrackAPI.Entities;

namespace DealTrackAPI.Repositories
{
    public interface IPropertyRepository
    {
        public Property GetProperty(int propertyId);
        public List<Property> GetProperties();
        public void CreateProperty(Property property);
        public void DeleteProperty(Property property);
        public void UpdateProperty(Property property);
    }
}
