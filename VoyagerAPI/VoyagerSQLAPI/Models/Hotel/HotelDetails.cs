using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Hotel
{
    public class HotelDetails
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public Status? HotelStatus { get; set; } //active , onbreak, outranged
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public bool BeachResort { get; set; }//a ka beach
        public bool PackageInclude { get; set; } // a ka include packages
        public int? PackageId { get; set; } //nese ka atehere package id 
        public string Details { get; set; }
        public string HotelPhoto { get; set; }

        public int HotelSize { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }
        public bool Restriction { get; set; }
    }
    public enum Status
    {
        active, obreak, outranged //maybe ill send them on db
    }
}
