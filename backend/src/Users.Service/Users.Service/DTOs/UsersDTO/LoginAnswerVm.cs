using System.ComponentModel.DataAnnotations;

namespace Users.Service.DTOs.UsersDTO;

public class LoginAnswerVm
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string JwtToken { get; set; } = string.Empty;
}