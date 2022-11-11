using E_Commerce_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_BE.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}
