using Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
  public class RackContext : DbContext
  {
    public RackContext(DbContextOptions<RackContext> options) : base(options)
    {
    }

    public DbSet<Rack> Racks { get; set; }
  }
}