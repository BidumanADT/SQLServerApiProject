using Microsoft.EntityFrameworkCore;
using MyApiProject.Models;

namespace MyApiProject.Data
{
    public class MyApiDbContext : DbContext
    {
        public MyApiDbContext(DbContextOptions<MyApiDbContext> options) : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    }
}