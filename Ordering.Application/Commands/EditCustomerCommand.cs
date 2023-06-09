﻿using MediatR;
using Ordering.Application.Response;

namespace Ordering.Application.Commands
{
    public class EditCustomerCommand : IRequest<CustomerResponse>
    {

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
