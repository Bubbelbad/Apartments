using Apartments.Domain.Abstractions;

namespace Apartments.Domain.Users.Events
{
    public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
}
