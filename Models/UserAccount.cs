using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models;

public class UserAccount
{
    [Key]
    public int UserAccountId { get; set; }

    [Required]
    [StringLength(150)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(254)]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
