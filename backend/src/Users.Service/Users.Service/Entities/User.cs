using Users.Service.Enums;

namespace Users.Service.Entities;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; } = DateTime.Now;

    public int? Gender { get; set; } = (int)Genders.Female;
    public int? Age { get; set; } = null;
    public string? City { get; set; } = "Москва";

    public int RoleId { get; set; } = (int)Roles.User;
    public Role Role { get; set; } = null!;
}