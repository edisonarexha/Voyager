using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Models;
using VoyagerSQLAPI.Models.Hotel;
using VoyagerSQLAPI.Models.Users;
using VoyagerSQLAPI.Models.Tickets;
using VoyagerSQLAPI.Models.AppLogs;
using VoyagerSQLAPI.Models.TeamMembers;
using VoyagerSQLAPI.Models.Hotel.HotelDetailsProc;
using VoyagerSQLAPI.Models.PaymentGateWay;
using VoyagerSQLAPI.Models.PackagesData;

namespace VoyagerSQLAPI.Data
{
    public class VoyagerDbContext : DbContext
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
        public DbSet<TicketDetails> TicketsDetails { get; set; }
        public DbSet<Destination> destination { get; set; }
        public DbSet<FlightData> FlightsDatas { get; set; }
        public DbSet<VoyagerSQLAPI.Models.TripProcedure.outputTrip>? outputTrip { get; set; }

        public DbSet<AppLogsData> appLogs { get; set; }
        public DbSet<TeamMembersData> teamMembers { get; set; }
        public DbSet<PackagesData> packagesDatas { get; set; }
        public DbSet<HotelDetailsProc_Out> hotelproc { get; set; }
        public DbSet<PaymentDetails> paymentdata { get; set; }
        public DbSet<SuccessPaymentGateAway> paymentSucc {get;set;}
    }
}
