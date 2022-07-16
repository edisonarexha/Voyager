using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Tickets
{
    public class TicketDetails
    {
        [Key]
        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public int UserId { get; set; }
    
     
        public int TicketNumber { get; set; }   
        public int FlightNumber { get; set; }
        public DateTime Arrival{ get; set; }
        public DateTime Departure { get; set; }
        public int? PackageId { get; set; }
        public int? HotelId { get; set; }

        public int DestinationId { get; set; }
        public decimal FlightPrice { get; set; }

    }
}
