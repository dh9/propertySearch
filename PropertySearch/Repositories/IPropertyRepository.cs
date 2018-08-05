using System.Collections.Generic;
using PropertySearch.Models;

namespace PropertySearch.Repositories
{
    public interface IPropertyRepository
    {
        List<Property> GetProperties(Requirements requirements);
    }
}