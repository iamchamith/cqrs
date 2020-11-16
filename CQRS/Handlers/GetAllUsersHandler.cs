using CQRS.AppServices;
using CQRS.Models;
using CQRS.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handlers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        IUserAppService _userAppService;
        public GetAllUsersHandler(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return _userAppService.GetUsers();
        }
    }
}
