using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Models;
using VoyagerSQLAPI.Models.Hotel;
using VoyagerSQLAPI.Models.Users;

namespace VoyagerSQLAPI.Data
{
    public class VoyagerDbContext:DbContext
    {
        public VoyagerDbContext(DbContextOptions<VoyagerDbContext> options)
            : base(options) { 
        }

        public DbSet<VoyagerToBeDeleted> voyagers { get; set; }
        public DbSet<HotelDetails> hotels { get; set; }
        public DbSet<Users> users { get; set; }
    }
}
