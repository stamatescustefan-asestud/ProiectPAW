using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComertApp.Entities
{
    public class ComertDbContext : DbContext
    {
        public ComertDbContext()
        {
            try 
            {
                Database.Migrate();
            } 
            catch(Exception)
            {
                Console.WriteLine("Database already exists. No additional migrations have to be applied.");
            }
        }

        public DbSet<Magazin> Magazine { get; set; }
        public DbSet<Raion> Raioane { get; set; }
        public DbSet<Desfacere> Desfaceri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comert.db");
        }
    }
}
