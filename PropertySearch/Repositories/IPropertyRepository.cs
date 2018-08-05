using System.Collections.Generic;
using System.IO;
using PropertySearch.Models;

namespace PropertySearch.Repositories
{
    public interface IPropertyRepository
    {
        List<Property> GetProperties(Requirements requirements);
        string Image(string id);
    }
}