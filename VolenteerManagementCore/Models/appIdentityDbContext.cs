using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VolenteerManagementCore.Models
{
    public class appIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public appIdentityDbContext(DbContextOptions<appIdentityDbContext> options) : base(options) { }
    }
}
