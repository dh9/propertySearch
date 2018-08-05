using System;
using System.Collections.Generic;
using System.IO;
using PropertySearch.Models;

namespace PropertySearch.Repositories
{
    /// <summary>
    /// Property Repository returning static data for demo purposes
    /// </summary>
    public class PropertyRepository : IPropertyRepository
    {
        /// <summary>
        /// Returns static Property info
        /// </summary>
        /// <param name="requirements">Search requirements</param>
        /// <returns>List of Property details</returns>
        public List<Property> GetProperties(Requirements requirements)
        {
            return new List<Property>()
            {
                new Property
                {
                    Id = "0a5655c6-b288-401a-8317-122561bdda4e",
                    Price = 250000,
                    Bedrooms = 3,
                    Postcode = "WR5 3FB"
                },
                new Property
                {
                    Id = "b92c6557-4f47-4bd6-acb2-9850199426ab",
                    Price = 275000,
                    Bedrooms = 4,
                    Postcode = "WR5 2AB"
                },
            };
        }

        /// <summary>
        /// Returns files from images folder in Base64 encoded string
        /// </summary>
        /// <param name="id">Image Id</param>
        /// <returns>Base64 encoded image contents</returns>
        public string Image(string id)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Properties", id + ".png"); 
            byte[] b = System.IO.File.ReadAllBytes(path);
            return "data:image/png;base64," + Convert.ToBase64String(b);
        }
    }
}