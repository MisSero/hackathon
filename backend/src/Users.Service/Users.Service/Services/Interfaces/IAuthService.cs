using Users.Service.DTOs.UsersDTO;

namespace Users.Service.Services.Interfaces;

public interface IAuthService
{
    public Task<LoginAnswerVm?> Login(LoginUserVm loginUserVm);

    public Task<int?> Register(RegisterUserVm registerUserVm);
}