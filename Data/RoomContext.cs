using Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
  public class RoomContext : DbContext
  {
    public RoomContext(DbContextOptions<RoomContext> options) : base(options)
    {
    }
    

    public DbSet<Room> Rooms { get; set; }
    
  }
}