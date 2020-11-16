using CQRS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.AppServices
{
    public interface IUserAppService
    {
        Task CreateUser(User model);
        Task<List<User>> GetUsers();
    }
}
