using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarStoreAPI.Models;

public class Car
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid CarId { get; set; }

    [Required]
    public string? Model { get; set; }

    [Required]
    public string? Brand { get; set; }

    public string? Color { get; set; }

    [Required]
    public string? Plate { get; set; }

    [Required]
    public DateTime LaunchDate { get; set; }

    public Guid OwnerId { get; set; }

    [ForeignKey("OwnerId")]
    public virtual Person? Owner { get; set; }
}
