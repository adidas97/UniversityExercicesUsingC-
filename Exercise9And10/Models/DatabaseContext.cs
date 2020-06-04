using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdentityUser = Microsoft.AspNetCore.Identity.IdentityUser;

namespace Lab9.Models
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) :
        base(options)
        {
        }
        public DbSet<ProductDB> Products { get; set; }
        public DbSet<CategoryDB> Categories { get; set; }
    }
}