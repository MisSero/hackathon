using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Users.Service.Converters;
using Users.Service.Database;
using Users.Service.DTOs.UsersDTO;

namespace Users.Service.Controllers;

/// <summary>
/// Контроллер для работы с аутентификацией.
/// </summary>
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserStorage _userStorage;

    public UserController(IUserStorage userStorage)
    {
        _userStorage = userStorage;
    }
    
    /// <summary>
    /// Получение информации по пользователю.
    /// </summary>
    /// <response code="200">Успешное получение информации по пользователю.</response>
    /// <response code="400">Информация по пользователю не найдена.</response>
    [ProducesResponseType(typeof(UserInfo), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpGet("info")]
    [Authorize]
    public async Task<IActionResult> GetUserInfo()
    {
        var idString = User.FindFirstValue("Id");

        if (idString == null)
        {
            return Problem("Не удалось получить информацию по пользователю",
                statusCode: StatusCodes.Status404NotFound);
        }

        int id = int.Parse(idString);

        var user = await _userStorage.GetUserById(id);

        if (user == null)
        {
            return Problem("Не удалось получить информацию по пользователю",
                statusCode: StatusCodes.Status404NotFound);
        }

        return Ok(UserConverter.ConvertModelToUserInfo(user));
    }
}