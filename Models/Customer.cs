using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  [Table("customers")]
  public class Customer
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("email")]
    public string Email { get; set; } = null!;

    [Column("address")]
    public string Address { get; set; } = null!;

    [Column(TypeName="Date")]
    public DateTime date_birth { get; set; }
    
  }
}