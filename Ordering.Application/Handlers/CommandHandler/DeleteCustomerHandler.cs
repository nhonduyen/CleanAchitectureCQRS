﻿using MediatR;
using Ordering.Application.Commands;
using Ordering.Core.Repositories.Command;
using Ordering.Core.Repositories.Query;

namespace Ordering.Application.Handlers.CommandHandler
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, String>
    {
        private readonly ICustomerCommandRepository _customerCommandRepository;
        private readonly ICustomerQueryRepository _customerQueryRepository;
        public DeleteCustomerHandler(ICustomerCommandRepository customerRepository, ICustomerQueryRepository customerQueryRepository)
        {
            _customerCommandRepository = customerRepository;
            _customerQueryRepository = customerQueryRepository;
        }

        public async Task<string> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var customerEntity = await _customerQueryRepository.GetByIdAsync(request.Id);

                await _customerCommandRepository.DeleteAsync(customerEntity, cancellationToken);
            }
            catch (Exception exp)
            {
                throw (new ApplicationException(exp.Message));
            }

            return "Customer information has been deleted!";
        }
    }
}
