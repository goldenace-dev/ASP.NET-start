using Microsoft.EntityFrameworkCore;

namespace eshop.Models
{
    public class MyDbContext : DbContext
    {

        public DbSet<Person> People {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
