using MediatR;
using System;

namespace CQRS.Commands
{
    public class CreateUserCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
