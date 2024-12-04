using Microsoft.EntityFrameworkCore;

namespace InMemoryDBinASP.NET.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDB");
        }
    }
}
