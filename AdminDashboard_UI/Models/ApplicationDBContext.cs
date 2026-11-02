using Microsoft.EntityFrameworkCore;

namespace AdminDashboard_UI.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
