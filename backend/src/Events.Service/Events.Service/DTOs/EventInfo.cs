using System.ComponentModel.DataAnnotations;

namespace Events.Service.DTOs;

public class EventInfo
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Название.
    /// </summary>
    [Required]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор пользователя, создавшего событие.
    /// </summary>
    [Required]
    public int CreatorId { get; set; }

    /// <summary>
    /// Тип события.
    /// </summary>
    [Required]
    public string EventType { get; set; } = string.Empty;

    /// <summary>
    /// Формат события.
    /// </summary>
    [Required]
    public string Format { get; set; } = string.Empty;

    /// <summary>
    /// Адрес.
    /// </summary>
    [Required]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Округ.
    /// </summary>
    [Required]
    public string District { get; set; } = string.Empty;

    /// <summary>
    /// Район.
    /// </summary>
    [Required]
    public string Region { get; set; } = string.Empty;

    /// <summary>
    /// Дата начала.
    /// </summary>
    [Required]
    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Дата завершения.
    /// </summary>
    [Required]
    public DateTime ExpirationDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Дата создания мероприятия.
    /// </summary>
    [Required]
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Возрастное ограничение.
    /// </summary>
    public int? AgeRating { get; set; }

    /// <summary>
    /// Описание события.
    /// </summary>
    [Required]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Тэги.
    /// </summary>
    [Required]
    public List<string> Tags { get; set; } = new List<string>();

    /// <summary>
    /// Ссылка на основную картинку события.
    /// </summary>
    [Required]
    public string MainImageLink { get; set; } = string.Empty;

    /// <summary>
    /// Коллекция ссылок на фотографии с события.
    /// </summary>
    [Required]
    public IEnumerable<string> ImagesLinks { get; set; } = new List<string>();

    /// <summary>
    /// Название организации.
    /// </summary>
    [Required]
    public string OrganizationName { get; set; } = string.Empty;

    /// <summary>
    /// Контактный номер телефона.
    /// </summary>
    [Required]
    public string PhoneNumber { get; set; } = string.Empty;

    /// <summary>
    /// ОГРН.
    /// </summary>
    public string OGRN { get; set; } = string.Empty;

    /// <summary>
    /// ИНН.
    /// </summary>
    public string INN { get; set; } = string.Empty;
}