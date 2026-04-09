using Microsoft.EntityFrameworkCore;
using FitnessApp.API.Models;

namespace FitnessApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}