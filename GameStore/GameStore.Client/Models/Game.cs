using System.ComponentModel.DataAnnotations;

namespace GameStore.Client.Models;

public class Game
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }
    [Required]
    [StringLength(20)]
    public required string Genre { get; set; }
    [Required]
    [Range(1, 200)]
    public float Price { get; set; }
    [Required]
    public DateTime ReleaseDate { get; set; }
}