using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesktopForm.Data
{
    public class FormContext : DbContext
    {
        public DbSet<Model.User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = E:\Amnil\Intern\SimpleDesktopForm\DesktopForm.db;");
        }
    }
}
