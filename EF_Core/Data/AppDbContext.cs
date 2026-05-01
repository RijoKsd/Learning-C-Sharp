using EF_Core.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
