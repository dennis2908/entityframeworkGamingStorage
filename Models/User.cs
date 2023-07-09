using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  [Table("users")]
  public class User
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("email")]
    public string Email { get; set; } = null!;

    [Column("address")]
    public string Address { get; set; } = null!;

    [Column("date_birth",TypeName="Date")]
    public DateTime DateBirth { get; set; }
    
  }
}