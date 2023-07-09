using Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
  public class RackRoomContext : DbContext
  {
    public RackRoomContext(DbContextOptions<RackRoomContext> options) : base(options)
    {
    }

    public DbSet<RackRoom> RackRooms { get; set; }
  }
}