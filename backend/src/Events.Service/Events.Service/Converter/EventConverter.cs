using Events.Service.DTOs;
using Events.Service.Entities;

namespace Events.Service.Converter;

public static class EventConverter
{
    public static EventBriefInfo ModelToEventBriefInfo(Event model)
    {
        var eventBriefInfo = new EventBriefInfo()
        {
            Id = model.Id,
            Address = model.Address,
            MainImageLink = model.MainImageLink,
            StartDate = model.StartDate,
            Title = model.Title,
        };

        return eventBriefInfo;
    }

    public static EventInfo ModelToEventInfo(Event model)
    {
        var eventInfo = new EventInfo()
        {
            Id = model.Id,
            Title = model.Title,
            CreatorId = model.CreatorId,
            EventType = model.EventType,
            Format = model.Format,
            Address = model.Address,
            District = model.District,
            Region = model.Region,
            StartDate = model.StartDate,
            ExpirationDate = model.ExpirationDate,
            CreationDate = model.CreationDate,
            AgeRating = model.AgeRating,
            Description = model.Description,
            Tags = model.Tags,
            MainImageLink = model.MainImageLink,
            ImagesLinks = model.ImagesLinks,
            OrganizationName = model.OrganizationName,
            PhoneNumber = model.PhoneNumber,
            OGRN = model.OGRN,
            INN = model.INN
        };

        return eventInfo;
    }

    public static Event CreatEventInfoToModel(CreateEventInfo createEventInfo)
    {
        var eventModel = new Event()
        {
            Title = createEventInfo.Title,
            CreatorId = createEventInfo.CreatorId,
            EventType = createEventInfo.EventType,
            Format = createEventInfo.Format,
            Address = createEventInfo.Address,
            District = createEventInfo.District,
            Region = createEventInfo.Region,
            StartDate = createEventInfo.StartDate,
            ExpirationDate = createEventInfo.ExpirationDate,
            CreationDate = DateTime.UtcNow,
            AgeRating = createEventInfo.AgeRating,
            Description = createEventInfo.Description,
            Tags = createEventInfo.Tags,
            MainImageLink = createEventInfo.MainImageLink,
            OrganizationName = createEventInfo.OrganizationName,
            PhoneNumber = createEventInfo.PhoneNumber,
            OGRN = createEventInfo.OGRN,
            INN = createEventInfo.INN
        };

        return eventModel;
    }
}