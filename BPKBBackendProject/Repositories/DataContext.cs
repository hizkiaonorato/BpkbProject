using Microsoft.EntityFrameworkCore;
using BPKBBackendProject.Models.Bpkb;
using BPKBBackendProject.Models.Location;

namespace BPKBBackendProject.Repositories
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("EmployeeConnect"));
        }

        public DbSet<ms_user> Users { get; set; }
        public DbSet<tr_Bpkb> Bpkbs { get; set; }
        public DbSet<ms_storage_location> Locations { get; set; }
    }
}
