using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PropertySearch.Models
{
    public class RequirementsViewModel
    {
        public int MinBedrooms { get; set; }
        public int MaxBedrooms { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        [Required]
        public string Postcode { get; set; }
        public int DistanceFromPostcode { get; set; }

        public List<Property> Properties { get; set; }
    }
}