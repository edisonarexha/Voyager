using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Packgages
{
    public class PackageDetails
    {
        [Key]
        public string PackageId { get; set; }
        [Required]
        public string PackageName { get; set; }
        [Required]
        public int HotelId { get; set; }
        public decimal PackagePrice { get; set; }
        public int TripId { get; set; }
        public string Destination { get; set; }
        public string Details { get; set; }
        public int TicketId { get; set; }
    }
}
