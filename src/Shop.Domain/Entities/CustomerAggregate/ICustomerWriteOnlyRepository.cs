using System;
using System.Threading.Tasks;
using Shop.Core.Abstractions;
using Shop.Core.ValueObjects;

namespace Shop.Domain.Entities.CustomerAggregate.Repositories;

public interface ICustomerWriteOnlyRepository : IWriteOnlyRepository<Customer>
{
    Task<bool> ExistsByEmailAsync(Email email);
    Task<bool> ExistsByEmailAsync(Email email, Guid currentId);
}