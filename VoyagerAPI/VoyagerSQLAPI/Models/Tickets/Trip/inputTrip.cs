using Microsoft.EntityFrameworkCore;

namespace VoyagerSQLAPI.Models.Tickets.Trip
{
    [Keyless]
    public class inputTrip
    {
        public int HotelId { get; set; }
    }
}
