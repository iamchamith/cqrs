using CQRS.AppServices;
using CQRS.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.AppServices
{
    public class UserAppService : IUserAppService
    {

        public async Task CreateUser(User model)
        {
            Console.WriteLine("Saved");
        }

        public async Task<List<User>> GetUsers()
        {

            return new List<User>() {
            new User{
                Id = Guid.NewGuid(),
                Name = "Chamith",
                Email  ="iamchamith@gmail.com"
            }, new User{
                Id = Guid.NewGuid(),
                Name = "Ruwan",
                Email  ="ruwan@gmail.com"
            }
            };
        }
    }
}
