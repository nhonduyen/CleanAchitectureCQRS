using Ordering.Core.Entities;

namespace Ordering.Core.Repositories.Query
{
    public interface ICustomerQueryRepository
    {
        Task<IReadOnlyList<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(Guid id);
        Task<Customer> GetCustomerByEmail(string email);
    }
}
