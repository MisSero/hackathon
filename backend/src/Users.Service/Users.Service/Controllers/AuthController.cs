using Microsoft.AspNetCore.Mvc;
using System.Web;
using Users.Service.DTOs.UsersDTO;
using Users.Service.Services.Interfaces;

namespace Users.Service.Controllers;

/// <summary>
/// Контроллер для работы с аутентификацией.
/// </summary>
[ApiController]
[Route("api/users/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    /// <summary>
    /// Регистрация нового пользователя.
    /// </summary>
    /// <param name="registerUserVm">Объект для регистрации пользователя.</param>
    /// <response code="200">Пользователь зарегистрирован, возвращает его id.</response>
    /// <response code="400">Пользователь с таким UserName уже существует.</response>
    [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUserVm registerUserVm)
    {
        long? id = await _authService.Register(registerUserVm);

        if (id == null)
        {
            return BadRequest(new ProblemDetails()
                { Detail = "Пользователь с таким никнеймом уже существует" });
        }

        return Ok(id);
    }

    /// <summary>
    /// Вход пользователя. Возвращает JWT-токен.
    /// </summary>
    /// <param name="loginUserVm">Объект для входа пользователя.</param>
    /// <response code="200">Вход выполнен успешно, возвращает структура данных с id и jwt-токеном.</response>
    /// <response code="400">Возвращается если введён неправильный логин или пароль.</response>
    [ProducesResponseType(typeof(LoginAnswerVm), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUserVm loginUserVm)
    {
        LoginAnswerVm? loginAnswerVm = await _authService.Login(loginUserVm);
        if (loginAnswerVm != null)
        {
            return Ok(loginAnswerVm);
        }

        return BadRequest(new ProblemDetails()
            { Detail = "Неправильный логин или пароль" });
    }
}
