using Microsoft.EntityFrameworkCore;

namespace VoyagerSQLAPI.Models.DashboardFunctions
{
    [Keyless]
    public class HotelPrice
    {
        public decimal hotelsPrice { get; set; }
    }
}
