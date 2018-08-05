namespace PropertySearch.Models
{
    public class Requirements
    {
        public int? MinBedrooms { get; set; }
        public int? MaxBedrooms { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string Postcode { get; set; }
        public int DistanceFromPostcode { get; set; }
    }
}