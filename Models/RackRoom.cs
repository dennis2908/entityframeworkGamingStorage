using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  public class RackRoom
  {
    public int Id { get; set; }

    public string Name { get; set; }  = null!;

    public int Room_no { get; set; }

    public int Rack_id { get; set; }

    public string Rack_name { get; set; }  = null!;

    public int Build_no { get; set; }
    
  }
}