using System.Collections.Generic;
using System.IO;
using PropertySearch.Models;

namespace PropertySearch.Repositories
{
    /// <summary>
    /// Repository for Property Listings
    /// </summary>
    public interface IPropertyRepository
    {
        /// <summary>
        /// Search repository for all propoerties which meet requirements
        /// </summary>
        /// <param name="requirements">search requirements</param>
        /// <returns>ll property details which match given requirements</returns>
        List<Property> GetProperties(Requirements requirements);

        /// <summary>
        /// Returns Base64 encoded image of given property
        /// </summary>
        /// <param name="id">Property Id</param>
        /// <returns>Base 64 encoded image data</returns>
        string Image(string id);
    }
}