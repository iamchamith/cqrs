using CQRS.AppServices;
using CQRS.Commands;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand>
    {
        IUserAppService _userAppService;
        public CreateUserHandler(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
