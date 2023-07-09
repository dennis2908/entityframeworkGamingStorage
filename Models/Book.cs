using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  [Table("books")]
  public class Book
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("rack_no")]
    public int RackNo { get; set; }

    [Column("publisher")]
    public string Publisher { get; set; } = null!;
 
    [Column(TypeName="Date")]
    public DateTime publish_date { get; set; }
    
  }
}