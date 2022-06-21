using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Models;
using VoyagerSQLAPI.Models.Hotel;
using VoyagerSQLAPI.Models.Users;
using VoyagerSQLAPI.Models.DB;
using VoyagerSQLAPI.Models.Packgages;
using VoyagerSQLAPI.Models.Tickets;
using VoyagerSQLAPI.Models.TripProcedure;
using VoyagerSQLAPI.Models.AppLogs;

namespace VoyagerSQLAPI.Data
{
    public class VoyagerDbContext:DbContext
    {


        public VoyagerDbContext()
        {
        }

        public VoyagerDbContext(DbContextOptions<VoyagerDbContext> options)
            : base(options) { 
        }
        public DbSet<HotelRooms> hotelrooms { get; set; }
        public DbSet<HotelDatas> hotelDatas { get; set; }
        public DbSet<VoyagerToBeDeleted> voyagers { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<VoyagerSQLAPI.Models.DB.output>? output { get; set; }
        public DbSet<PackageDetails> PackagesDetails { get; set; }
        public DbSet<TicketDetails> TicketsDetails { get; set; }
        public DbSet<Destination> destination { get; set; }
        public DbSet<FlightData> FlightsDatas { get; set; }
        public DbSet<VoyagerSQLAPI.Models.TripProcedure.outputTrip>? outputTrip { get; set; }
     
        public DbSet<AppLogsData> appLogs { get; set; }
    }
}
