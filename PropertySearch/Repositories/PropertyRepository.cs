using System;
using System.Collections.Generic;
using System.IO;
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

        public string Image(string id)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Properties", id + ".png"); 
            byte[] b = System.IO.File.ReadAllBytes(path);
            return "data:image/png;base64," + Convert.ToBase64String(b);

            //var stream = File.OpenRead(path);
            //Convert.ToBase64String(stream.Re);
            //return stream;
        }
    }
}