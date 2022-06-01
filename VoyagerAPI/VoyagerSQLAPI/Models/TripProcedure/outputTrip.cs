using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.TripProcedure
{
    public class outputTrip
    {
        [Key]
        public int UserId { get; set; }
        public string PackageName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int? HotelId { get; set; }
        public string HotelName { get; set; }   
        public string Address { get; set; }   
        public string TicketName { get; set; } 
        public int FlightNumber { get; set; }
        public string AirCraftName { get; set; }
        public int TailNumber { get; set; }
        public string CompanyName { get; set; }

    }
}
