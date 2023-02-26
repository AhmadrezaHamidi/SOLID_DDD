using System;

namespace Shop.Domain.Entities.CustomerAggregate.Events;

/// <summary>
/// Evento que representa uma atualização de um cliente.
/// </summary>
public class CustomerUpdatedEvent : CustomerBaseEvent
{
    public CustomerUpdatedEvent(
        Guid id,
        string firstName,
        string lastName,
        EGender gender,
        string email,
        DateTime dateOfBirth) : base(id, firstName, lastName, gender, email, dateOfBirth)
    {
    }
}