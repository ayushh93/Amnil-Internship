
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Data
{
    public class EFContext : DbContext 
    {
        public DbSet<Model.User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\Amnil\Intern\EntityFrameWorkApp\EntityFrameworkApp.db;");
        }
    }
}
