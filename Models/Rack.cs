using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  [Table("racks")]
  public class Rack
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("room_no")]
    public int Room_no { get; set; }

    //public virtual List<Room> Rooms { get; set; }  
    
  }
  
}