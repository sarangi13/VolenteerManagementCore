using Microsoft.EntityFrameworkCore;

namespace VolenteerManagementCore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Volenteer> Volenteers { get; set; }
    }
}