using System.Collections.Generic;
using PropertySearch.Models;

namespace PropertySearch.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        public List<Property> GetProperties(Requirements requirements)
        {
            return new List<Property>()
            {
                new Property
                {
                    Price = 250000,
                    Bedrooms = 3,
                    Postcode = "WR5 3FB"
                },
                new Property
                {
                    Price = 275000,
                    Bedrooms = 4,
                    Postcode = "WR5 2AB"
                },
            };
        }
    }
}