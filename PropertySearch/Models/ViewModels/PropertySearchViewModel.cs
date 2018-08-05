using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PropertySearch.Models.ViewModels
{
    public class PropertySearchViewModel
    {
        [Display(Name="Min Bedrooms")]
        public int? MinBedrooms { get; set; }

        [Display(Name="Max Bedrooms")]
        public int? MaxBedrooms { get; set; }

        [Display(Name="Min Price")]
        public int? MinPrice { get; set; }

        [Display(Name="Min Price")]
        public int? MaxPrice { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Display(Name="Search area")]
        [Required]
        public int DistanceFromPostcode { get; set; }

        public List<Property> Properties { get; set; }
    }
}