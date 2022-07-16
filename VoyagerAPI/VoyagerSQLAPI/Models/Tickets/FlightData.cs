using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Tickets
{
    public class FlightData
    {
        [Key]
        public int FlightNumber { get; set; }
        public string FlightName { get; set; }
        public DateTime FlightDate { get; set; }
        public string CompanyName { get; set; }
        [Required]
        public string AirCraftName { get; set; }
        [Required]
        public int TailNumber { get; set; }
        public decimal FlightPrice { get; set; }

    }
}
