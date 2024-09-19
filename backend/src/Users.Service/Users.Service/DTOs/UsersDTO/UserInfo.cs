using System.ComponentModel.DataAnnotations;
using Users.Service.Enums;

namespace Users.Service.DTOs.UsersDTO;

public class UserInfo
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string UserName { get; set; } = string.Empty;
    [Required]
    public string Email { get; set; } = string.Empty;
    [Required]
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    [Required]
    public string Role { get; set; } = string.Empty;
    
    public int? Gender { get; set; } = (int)Genders.Female;
    public int? Age { get; set; } = null;
    public string? City { get; set; } = "Москва";
}