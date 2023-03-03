using Microsoft.EntityFrameworkCore;

namespace MVCCRUD.Data
{
    public class MVCContext:DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Category> Categories { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            =>optionsBuilder.UseSqlite(@"Data Source = E:\Amnil\Intern\MVCCRUD\DemoMVC.db");*/
    }
}
