using MediatR;
using Ordering.Core.Entities;

namespace Ordering.Application.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; private set; }

        public GetCustomerByIdQuery(Guid Id)
        {
            this.Id = Id;
        }

    }
}
