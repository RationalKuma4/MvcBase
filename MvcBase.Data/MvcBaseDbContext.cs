using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcBase.Models;

namespace MvcBase.Data
{
    public class MvcBaseDbContext : IdentityDbContext<ApplicationUser, Role, int>
    {
        public MvcBaseDbContext(DbContextOptions<MvcBaseDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
                .Ignore(e => e.FullName);
        }
    }
}
