using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Customers
{
    public Guid Id { get; set; }
    [Required]
    [StringLength(16, ErrorMessage = "FirstName too long (16 character limit).")]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [StringLength(16, ErrorMessage = "LastName too long (16 character limit).")]
    public string LastName { get; set; } = string.Empty;
    [Required]
    [StringLength(16, ErrorMessage = "FirstName too long (16 character limit).")]
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool OptIn { get; set; }
}