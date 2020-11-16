using CQRS.Models;
using MediatR;
using System.Collections.Generic;
namespace CQRS.Queries
{
    public class GetAllUsersQuery : IRequest<List<User>>
    {
    }
}
