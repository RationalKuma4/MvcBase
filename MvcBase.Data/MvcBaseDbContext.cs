using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcBase.Models;

namespace MvcBase.Data
{
    public class MvcBaseDbContext : IdentityDbContext<ApplicationUser>
    {
        public MvcBaseDbContext(DbContextOptions<MvcBaseDbContext> options)
            : base(options)
        {

        }
    }
}
