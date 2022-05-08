using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Models;

namespace VoyagerSQLAPI.Data
{
    public class VoyagerDbContext:DbContext
    {
        public VoyagerDbContext(DbContextOptions<VoyagerDbContext> options)
            : base(options) { 
        }

        public DbSet<VoyagerToBeDeleted> voyagers { get; set; }
    }
}
