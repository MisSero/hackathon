using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Users.Service.Auth;
using Users.Service.Database;
using Users.Service.DTOs.UsersDTO;
using Users.Service.Entities;
using Users.Service.Services.Interfaces;

namespace Users.Service.Services.Implementations;

public class AuthService : IAuthService
{
    private readonly IUserStorage _userStorage;
    private readonly IPasswordHasher<User> _passwordHasher;

    public AuthService(IUserStorage userStorage,
        IPasswordHasher<User> passwordHasher)
    {
        _userStorage = userStorage;
        _passwordHasher = passwordHasher;
    }

    public async Task<LoginAnswerVm?> Login(LoginUserVm loginUserVm)
    {
        var user = await _userStorage.GetUserByUsername(loginUserVm.UserName);

        if (user != null)
        {
            var saltedPassword = loginUserVm.Password + AuthOptions.Salt;

            var passwordHash = _passwordHasher.VerifyHashedPassword(user,
                user.PasswordHash, saltedPassword);
            if (passwordHash == PasswordVerificationResult.Success)
            {
                var claims = new List<Claim>
                {
                    new ("id", user.Id.ToString()),
                    new ("name", user.UserName),
                    new ("email", user.Email),
                    new ("role", user.Role?.Name ?? "")
                };

                var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.Issuer,
                    audience: AuthOptions.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromDays(3)),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials(
                        AuthOptions.GetSymmetricSecurityKey(),
                        SecurityAlgorithms.HmacSha256)
                    );

                return new LoginAnswerVm()
                {
                    Id = user.Id,
                    JwtToken = new JwtSecurityTokenHandler().WriteToken(jwt)
                };
            }
        }
        return null;
    }

    public async Task<int?> Register(RegisterUserVm registerUserVm)
    {
        var user = await _userStorage.GetUserByUsername(registerUserVm.UserName);
        if (user != null)
        {
            return null;
        }

        string saltedPassword = registerUserVm.Password + AuthOptions.Salt;
        user = new User()
        {
            UserName = registerUserVm.UserName,
            Email = registerUserVm.Email
        };
        user.PasswordHash = _passwordHasher.HashPassword(user, saltedPassword);

        int id = await _userStorage.AddAsync(user);

        return id;
    }
}