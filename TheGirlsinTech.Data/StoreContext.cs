using TheGirlsinTech.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace TheGirlsinTech.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        { }
        public DbSet<Item> Items { get; set; }
    }
}

