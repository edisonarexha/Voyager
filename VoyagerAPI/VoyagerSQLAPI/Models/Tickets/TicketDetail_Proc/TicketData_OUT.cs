using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Tickets.TicketDetail_Proc
{
    [Keyless]
    public class TicketData_OUT
    {
        
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? HotelDesc { get; set; }
        public DateTime? InsertedDate { get; set; }
        public int? HotelPrice { get; set; }
        public string? Address { get; set; }
        public string? Location { get; set; }
        public int? RoomId { get; set; }
        public int? TicketId { get; set; }
        public string? TicketName { get; set; }

        public int? TicketNumber { get; set; }
        public int? FlightNumber { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? Departure { get; set; }
        public int? PackageId { get; set; }

        public string? FlightName { get; set; }
        public DateTime? FlightDate { get; set; }
        public string? CompanyName { get; set; }

        public string? AirCraftName { get; set; }
        
        public int? TailNumber { get; set; }
        public int? MAXPassagerNumber { get; set; }
    }
}
