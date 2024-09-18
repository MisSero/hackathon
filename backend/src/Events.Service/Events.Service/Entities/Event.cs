namespace Events.Service.Entities;

public class Event
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название.
    /// </summary>
    public string Title { get; set; } = string.Empty;
    
    /// <summary>
    /// Идентификатор пользователя, создавшего событие.
    /// </summary>
    public int CreatorId { get; set; }
    
    /// <summary>
    /// Тип события.
    /// </summary>
    public string EventType { get; set; } = string.Empty;
    
    /// <summary>
    /// Формат события.
    /// </summary>
    public string Format { get; set; } = string.Empty;
    
    /// <summary>
    /// Адрес.
    /// </summary>
    public string Address { get; set; } = string.Empty;
    
    /// <summary>
    /// Округ.
    /// </summary>
    public string District { get; set; } = string.Empty;
    
    /// <summary>
    /// Район.
    /// </summary>
    public string Region { get; set; } = string.Empty;

    /// <summary>
    /// Дата начала.
    /// </summary>
    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Дата завершения.
    /// </summary>
    public DateTime ExpirationDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Дата создания мероприятия.
    /// </summary>
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Возрастное ограничение.
    /// </summary>
    public int AgeRating { get; set; }

    /// <summary>
    /// Описание события.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Тэги.
    /// </summary>
    public List<string> Tags { get; set; } = new List<string>();

    /// <summary>
    /// Ссылка на основную картинку события.
    /// </summary>
    public string MainImageLink { get; set; } = string.Empty;

    /// <summary>
    /// Коллекция ссылок на фотографии с события.
    /// </summary>
    public List<string> ImagesLinks { get; set; } = new List<string>();

    /// <summary>
    /// Статус события. При запросе на создание события оно должно
    /// пройти проверку модератора для публикации.
    /// </summary>
    public bool IsVerified { get; set; } = false;

    // Данные организации создателя

    /// <summary>
    /// Название организации.
    /// </summary>
    public string OrganizationName { get; set; } = string.Empty;

    /// <summary>
    /// Контактный номер телефона.
    /// </summary>
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
