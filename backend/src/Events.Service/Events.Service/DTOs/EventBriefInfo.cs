using System.ComponentModel.DataAnnotations;

namespace Events.Service.DTOs;

/// <summary>
/// Краткая информация по событию.
/// </summary>
public class EventBriefInfo
{
    /// <summary>
    /// Идентификатор события.
    /// </summary>
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Название события.
    /// </summary>
    [Required]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Адрес события.
    /// </summary>
    [Required]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Дата начала события.
    /// </summary>
    [Required]
    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Ссылка на основную картинку события.
    /// </summary>
    [Required]
    public string MainImageLink { get; set; } = string.Empty;
}