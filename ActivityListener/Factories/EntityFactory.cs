using ActivityListener.Boundary;
using ActivityListener.Domain;
using ActivityListener.Infrastructure;
using System;

namespace ActivityListener.Factories
{
    public static class EntityFactory
    {
        public static ActivityHistoryDB ToDatabase(this ActivityHistoryEntity entity)
        {
            return new ActivityHistoryDB
            {
                Id = entity.Id,
                CreatedAt = entity.CreatedAt,
                Type = entity.Type,
                SourceDomain = entity.SourceDomain,
                OldData = entity.OldData,
                TimetoLiveForRecord = entity.TimetoLiveForRecord,
                TargetType = entity.TargetType,
                TargetId = entity.TargetId,
                NewData = entity.NewData,
                AuthorDetails = entity.AuthorDetails
            };
        }

        public static ActivityType GetActivityType(this EntityEventSns eventSns)
        {
            switch (eventSns.EventType)
            {
                case EventTypes.PersonCreatedEvent:
                case EventTypes.ContactDetailAddedEvent:
                case EventTypes.TenureCreatedEvent:
                case EventTypes.PersonAddedToTenureEvent:
                    return ActivityType.create;
                case EventTypes.PersonUpdatedEvent:
                case EventTypes.TenureUpdatedEvent:
                    return ActivityType.update;
                case EventTypes.ContactDetailDeletedEvent:
                    return ActivityType.delete;

                default:
                    throw new ArgumentException($"Unknown event type: {eventSns.EventType}");
            }
        }

        public static TargetType GetTargetType(this EntityEventSns eventSns)
        {
            switch (eventSns.EventType)
            {
                case EventTypes.PersonCreatedEvent:
                case EventTypes.PersonUpdatedEvent:
                    return TargetType.person;
                case EventTypes.ContactDetailAddedEvent:
                case EventTypes.ContactDetailDeletedEvent:
                    return TargetType.contactDetails;
                case EventTypes.TenureCreatedEvent:
                case EventTypes.TenureUpdatedEvent:
                    return TargetType.tenure;
                case EventTypes.PersonAddedToTenureEvent:
                    return TargetType.tenurePerson;

                default:
                    throw new ArgumentException($"Unknown event type: {eventSns.EventType}");
            }
        }

        public static AuthorDetails GetAuthorDetails(this EntityEventSns eventSns)
        {
            return new AuthorDetails
            {
                Email = eventSns.User.Email,
                FullName = eventSns.User.Name
            };
        }

        public static ActivityHistoryEntity ToDomain(this EntityEventSns eventSns)
        {
            return new ActivityHistoryEntity
            {
                Id = Guid.NewGuid(),
                Type = eventSns.GetActivityType(),
                SourceDomain = eventSns.SourceDomain,
                TargetType = eventSns.GetTargetType(),
                TargetId = eventSns.EntityId,
                CreatedAt = eventSns.DateTime,
                TimetoLiveForRecord = default,
                OldData = eventSns.EventData.OldData,
                NewData = eventSns.EventData.NewData,
                AuthorDetails = eventSns.GetAuthorDetails()
            };
        }
    }
}
