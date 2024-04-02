using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nestHome.Models;

namespace nestHome.Contexts
{
    public class NestDbContext : IdentityDbContext<AppUser>
    {
        public NestDbContext(DbContextOptions<NestDbContext> options) : base(options)
        {
        }
    }
}
