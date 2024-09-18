using Events.Service.Converter;
using Events.Service.Database;
using Events.Service.DTOs;
using Events.Service.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Events.Service.Controllers;

/// <summary>
/// Контроллер для работы с аутентификацией.
/// </summary>
[ApiController]
[Route("api/users/[controller]")]
public class EventsController : ControllerBase
{
    private readonly IEventStorage _eventStorage;

    public EventsController(IEventStorage eventStorage)
    {
        _eventStorage = eventStorage;
    }

    /// <summary>
    /// Получения списка всех проверенных событий.
    /// </summary>
    /// <response code="200">Список проверенных событий успешно получен.</response>
    [ProducesResponseType(typeof(IEnumerable<EventBriefInfo>), StatusCodes.Status200OK)]
    [HttpGet("verified")]
    public async Task<IActionResult> GetAllVerifiedEvents()
    {
        var events = await _eventStorage.GetAllVerifiedEvents();

        var eventsBriefInfo = new List<EventBriefInfo>();

        foreach (var eventModel in events)
        {
            eventsBriefInfo.Add(EventConverter.ModelToEventBriefInfo(eventModel));
        }

        return Ok(eventsBriefInfo);
    }

    /// <summary>
    /// Получение информации мероприятия по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор события.</param>
    /// <response code="200">Информация по событию \успешно получена.</response>
    /// <response code="404">Событие с таким идентификатором не найдено.</response>
    [ProducesResponseType(typeof(EventInfo), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEventById(int id)
    {
        var eventModel = _eventStorage.GetEventById(id);

        if (eventModel == null)
        {
            return Problem("Событие с таким идентификатором не найдено.", statusCode:StatusCodes.Status404NotFound);
        }

        var eventInfo = EventConverter.ModelToEventInfo(eventModel);

        return Ok(eventInfo);
    }

    /// <summary>
    /// Получения списка всех непроверенных мероприятий.
    /// </summary>
    /// <response code="200">Список проверенных мероприятий успешно получен.</response>
    [ProducesResponseType(typeof(IEnumerable<EventBriefInfo>), StatusCodes.Status200OK)]
    [HttpGet("unverified")]
    [Authorize(Roles = $"{nameof(Roles.Admin)}")]
    public async Task<IActionResult> GetAllUnVerifiedEvents()
    {
        var events = await _eventStorage.GetAllUnVerifiedEvents();

        var eventsBriefInfo = new List<EventBriefInfo>();

        foreach (var eventModel in events)
        {
            eventsBriefInfo.Add(EventConverter.ModelToEventBriefInfo(eventModel));
        }

        return Ok(eventsBriefInfo);
    }

    /// <summary>
    /// Добавление мероприятия.
    /// </summary>
    /// <param name="createEventInfo">Создаваемое мероприятие.</param>
    /// <response code="200">Идентификатор добавленного мероприятия.</response>
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddEvent(CreateEventInfo createEventInfo)
    {
        var eventModel = EventConverter.CreatEventInfoToModel(createEventInfo);

        var eventId = await _eventStorage.AddEvent(eventModel);

        return Ok(eventId);
    }

    /// <summary>
    /// Верификация мероприятия.
    /// </summary>
    /// <response code="200">Мероприятие успешно добавлено.</response>
    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpPatch("verify/{id}")]
    [Authorize(Roles = $"{nameof(Roles.Admin)}")]
    public async Task<IActionResult> VerifyEvent(int id)
    {
        await _eventStorage.VerifyEvent(id);

        return Ok();
    }
}
