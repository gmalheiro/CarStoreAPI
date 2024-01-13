using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarStoreAPI.Models;

public class Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PersonId { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Surname { get; set; }

    [Required]
    public DateOnly Birthdate { get; set; }

    [Required]
    public string? DocumentNumber { get; set; }

    public virtual ICollection<Car>? Cars { get; set; }
}