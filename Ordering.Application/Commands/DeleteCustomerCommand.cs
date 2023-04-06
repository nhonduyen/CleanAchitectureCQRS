using MediatR;

namespace Ordering.Application.Commands
{
    public class DeleteCustomerCommand : IRequest<String>
    {
        public Guid Id { get; private set; }

        public DeleteCustomerCommand(Guid Id)
        {
            this.Id = Id;
        }
    }
}
