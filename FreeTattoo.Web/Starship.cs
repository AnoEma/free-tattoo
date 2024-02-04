using System.ComponentModel.DataAnnotations;

namespace FreeTattoo.Web;

public class Starship
{
    [Required]
    [StringLength(16,
    ErrorMessage = "Identifier too long (16 character limit).")]
    public string Identifier { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    [Required]
    public string Classification { get; set; } = string.Empty;

    [Range(1, 100000,
        ErrorMessage = "Accommodation invalid (1-100000).")]
    public int MaximumAccommodation { get; set; }

    [Required]
    [Range(typeof(bool), "true", "true",
        ErrorMessage = "This form disallows unapproved ships.")]
    public bool IsValidatedDesign { get; set; }

    [Required]
    public DateTime ProductionDate { get; set; }
}
