using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Entities;

namespace ToDo.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
